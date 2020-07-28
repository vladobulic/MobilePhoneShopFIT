using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Web.Areas.Customer.Models;

namespace Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class MobitelController : Controller
    {
        private readonly IMobitelService mobitelService;
        private readonly UserManager<ApplicationUser> _userManager;
        public MobitelController(IMobitelService mobitelService, UserManager<ApplicationUser> userManager)
        {
            this.mobitelService = mobitelService;
            _userManager = userManager;
        }

        public IActionResult Index(int id)
        {
            var model = MobitelViewModel.ConvertToMobitelViewModel(mobitelService.GetMobitel(id));
            return View(model);
        }
    }
}
