using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RepositoryLayer;
using ServiceLayer.Classes.Helper;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Helpers;
using Web.Areas.Admin.Models;


namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAdministratorService administratorService;
        private readonly ILogService logService;
        private readonly IEmailService emailService;


        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> _signInManager, RoleManager<IdentityRole> roleManager,  IAdministratorService administratorService, IEmailService emailService, ILogService logService)
        {
            this.emailService = emailService;
            _userManager = userManager;
            this._signInManager = _signInManager;
            this._roleManager = roleManager;
            this.administratorService = administratorService;
            this.logService = logService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel()
            {
                selectListItems = _roleManager.Roles
                                           .Select(i => new SelectListItem()
                                           {
                                               Text = i.ToString(),
                                               Value = i.ToString()
                                           }).ToList()
        };
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,

                };
                var result = await _userManager.CreateAsync(user, model.Password);


                if (result.Succeeded)
                {
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var confirmationLink = Url.Action("ConfirmEmail", "Account",
                        new { userId = user.Id, token = token }, Request.Scheme);

                    MailRequest mail = new MailRequest
                    {
                        Subject = "Confirm your account",
                        Body = "Please confirm your email by clicking this link: <a href =\"" + confirmationLink + "\">link</a>",
                        ToEmail = model.Email
                    };
                    await emailService.SendEmailAsync(mail);


                    if (model.ImeRole != null && (model.ImeRole == "Admin" || model.ImeRole == "admin"))
                    {
                        
                                      Administrator admin = new Administrator()
                                       {
                                            ApplicationUser = user,
                                            Email = user.Email,
                                            Ime = "admin",
                                            Prezime = "admin",
                                            IsSuperAdmin = true
                                        };
                        result = await _userManager.AddToRoleAsync(user, model.ImeRole);
                        administratorService.InsertAdmin(admin);
                    }


                    if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Administration");
                    }


                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    //return RedirectToAction("Index", "Home");
                    ViewBag.Title = "Registration successful";
                    ViewBag.Message = "Before you can Login, please confirm your " +
                            "email, by clicking on the confirmation link we have emailed you";


                    return View("Poruka");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }


        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("index", "home");
            }

            var user = await _userManager.FindByIdAsync(userId);
           

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return View();
            }

            ViewBag.ErrorTitle = "Email cannot be confirmed";
            return View("Poruka");
        }


        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use.");
            }


        }

         

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {

            //throw new Exception("Error during login");

            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                //Email confirmation
                var user = await _userManager.FindByEmailAsync(model.Email);

                //if (user != null && !user.EmailConfirmed &&
                //            (await _userManager.CheckPasswordAsync(user, model.Password)))
                //{
                //    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                //    return View(model);
                //}

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                //if (result.RequiresTwoFactor)
                //{
                //    return RedirectToAction(nameof(SendCode), new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                //}
               
                
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    
                
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Error()
        {
            
            var putanja = HttpContext
                      .Features
                      .Get<IExceptionHandlerPathFeature>();
            if (putanja == null)
                return View();

            
            var exception = putanja.Error;
            var pathString = putanja.Path;


            //exception handler
            logService.InsertLog(ConvertToLog.CreateLog(exception, _userManager, HttpContext, pathString));
            emailService.SendEmailToMyselfAsync(new MailRequest { Body = exception.StackTrace, Subject = "Exception: " + exception.Message });
            return View();
        }


        //private IActionResult RedirectToLocal(string returnUrl)
        //{
        //    if (Url.IsLocalUrl(returnUrl))
        //    {
        //        return Redirect(returnUrl);
        //    }
        //    else
        //    {
        //        return RedirectToAction(nameof(HomeController.Index), "Admin");
        //    }
        //}

    }
}
