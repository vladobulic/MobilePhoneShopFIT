using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class PorukaController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IPorukaService porukaService;
        private readonly IAdministratorService administratorService;
        private readonly IZaposlenikService zaposlenikService;
        public PorukaController(IPorukaService porukaService, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IAdministratorService administratorService, IZaposlenikService zaposlenikService)
        {
            this.porukaService = porukaService;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.administratorService = administratorService;
            this.zaposlenikService = zaposlenikService;
        }
        public IActionResult Index()
        {
            //PregledPorukaViewModel model = new PregledPorukaViewModel
            //{

            //}
            var poruke = porukaService.GetPoruke().Select(x => PregledPorukaViewModel.ConvertToPorukaViewModel(x)).ToList();
            return View(poruke);
        }

       
        [HttpGet]
        [Authorize(Roles = "Zaposlenik")]
        public IActionResult PosaljiPorukuZaposlenik()
        {
            //var primatelji
            
            
                PregledPorukaViewModel model = new PregledPorukaViewModel()
                {
                    primatelji = userManager.Users.Where(k=>k.Administratori.Any())
                                           .Select(i => new SelectListItem()
                                           {
                                               Text = i.ToString(),
                                               Value = i.Id.ToString()
                                           }).ToList()
                };
            return View("PosaljiPorukuZaposlenik", model);


        
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult PosaljiPorukuAdmin()
        {
            //var primatelji


            PregledPorukaViewModel model = new PregledPorukaViewModel()
            {
                primatelji = userManager.Users.Where(k => k.Zaposlenici.Any())
                                       .Select(i => new SelectListItem()
                                       {
                                           Text = i.ToString(),
                                           Value = i.Id.ToString()
                                       }).ToList()
            };
            return View("PosaljiPoruku",model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PosaljiPorukuAdmin(PregledPorukaViewModel model)
        {
            if(ModelState.IsValid)
            {
                
                var posiljateljId = userManager.GetUserId(User);
                var posiljatelj = await userManager.FindByIdAsync(posiljateljId);

                

                //var adminId = administratorService.GetAdmini().Where(x => x.ApplicationUser.Id == posiljatelj.Id).Select(a => a.Id).FirstOrDefault();
                var admin = administratorService.GetAdminByAspUserId(posiljateljId);
                var zaposlenik = zaposlenikService.GetZaposlenikByAspUserId(model.primateljId);
            //var zaposlenikId = zaposlenikService.GetZaposlenikById(model.primateljId);



            Poruka novaPoruka = new Poruka
                {
                    Sadrzaj = model.sadrzaj,
                    Subjekt = model.subjekt,
                    DatumSlanja = DateTime.Now,
                    Procitano = false,
                    Hitno = false,
                    AdministratorId = admin,
                    ZaposlenikId = zaposlenik
            };
                porukaService.InsertPoruka(novaPoruka);
                return View("PorukaPoslana");
            }
            return View("PosaljiPoruku", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Zaposlenik")]
        public async Task<IActionResult> PosaljiPorukuZaposlenik(PregledPorukaViewModel model)
        {
            
            var posiljateljId = userManager.GetUserId(User);
            var posiljatelj = await userManager.FindByIdAsync(posiljateljId);

            var admin = administratorService.GetAdminByAspUserId(model.primateljId);
            var zaposlenik = zaposlenikService.GetZaposlenikByAspUserId(posiljateljId);

            

            Poruka novaPoruka = new Poruka
            {
                Sadrzaj = model.sadrzaj,
                Subjekt = model.subjekt,
                DatumSlanja = DateTime.Now,
                Procitano = true,
                Hitno = false,
                AdministratorId = admin,
                ZaposlenikId = zaposlenik
            };
            porukaService.InsertPoruka(novaPoruka);
            return View("PorukaPoslana");
        }
    }
}
