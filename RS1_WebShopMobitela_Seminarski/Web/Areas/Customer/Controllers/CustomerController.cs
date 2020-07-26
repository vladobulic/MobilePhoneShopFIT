using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Web.Areas.Customer.Models;

namespace Web.Areas.Customer.Controllers
{
    [Authorize]
    [Area("Customer")]
   
    public class CustomerController : Controller
    {
        private readonly IMobitelService mobitelService;

        public CustomerController(IMobitelService mobitelService)
        {
            this.mobitelService = mobitelService;
        }
        public IActionResult Index()
        {
            return View(MobitelViewModel.ConvertToMobitelViewModel(mobitelService.GetMobiteli()));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
