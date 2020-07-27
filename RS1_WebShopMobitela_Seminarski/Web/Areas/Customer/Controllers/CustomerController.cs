using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        public CustomerController(IMobitelService mobitelService, IProizvodjacService proizvodjacService)
        {
            this.mobitelService = mobitelService;
            this.proizvodjacService = proizvodjacService;
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Proizvodjaci = ListConverter.ConvertToSelectListItem(proizvodjacService.GetProizvodjaci());
            var mobiteli = mobitelService.GetMobiteli();
            if (mobiteli != null)
            {
                model.Mobiteli = MobitelViewModel.ConvertToMobitelViewModel(mobiteli);
                model.PriceTo = (int)Math.Ceiling(mobiteli.Max(x => x.Cijena));
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
