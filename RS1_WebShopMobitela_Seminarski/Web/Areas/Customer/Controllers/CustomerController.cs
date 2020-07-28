using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Internal;
using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Web.Areas.Customer.Helpers;
using Web.Areas.Customer.Models;

namespace Web.Areas.Customer.Controllers
{

    [Area("Customer")]

    public class CustomerController : Controller
    {
        private readonly IMobitelService mobitelService;
        private readonly IProizvodjacService proizvodjacService;
        private readonly ILogService logService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly int resultsPerPage = 6;

        public CustomerController(IMobitelService mobitelService, IProizvodjacService proizvodjacService, ILogService logService, UserManager<ApplicationUser> userManager)
        {
            this.mobitelService = mobitelService;
            this.proizvodjacService = proizvodjacService;
            this.logService = logService;
            _userManager = userManager;
        }
        public IActionResult Index(IndexViewModel model)
        {

            model.Proizvodjaci = Converter.ConvertToSelectListItem(proizvodjacService.GetProizvodjaci());


            var mobiteli = mobitelService.GetMobiteli();
            if (!mobiteli.IsNullOrEmpty())
                model.PriceTo = (int)Math.Ceiling(mobiteli.Max(x => x.Cijena));
            else
                model.PriceTo = 3500;


            int TotalPages = 0;
            model.Mobiteli = MobitelViewModel.ConvertToMobitelViewModel(mobitelService.GetMobiteliSorted(model.Page ?? 0, model.PriceDesc, model.SearchName, model.my_range, model.ProizvodjacId, resultsPerPage,ref TotalPages));
            model.TotalPages = TotalPages;

            // setup our slider data
            if (!string.IsNullOrEmpty(model.my_range))
            {
                model.sliderFrom = Convert.ToInt32(model.my_range.Split(';')[0]);
                model.sliderTo = Convert.ToInt32(model.my_range.Split(';')[1]);
            }
            else
            {
                model.sliderFrom = 0;
                model.sliderFrom = model.PriceTo;
            }
            
            
            return View(model);
        }



        public IActionResult Novosti()
        {

            return View();
        }

        public IActionResult Kontakt()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Retrieve error information in case of internal errors
            var path = HttpContext
                      .Features
                      .Get<IExceptionHandlerPathFeature>();
            if (path == null)
                return View();

            // Use the information about the exception 
            var exception = path.Error;
            var pathString = path.Path;


            // exception handler 
            logService.InsertLog(Converter.CreateLog( exception, _userManager, HttpContext, pathString));
            return View();
        }
    }
}
