using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Internal;
using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IKomentarService komentarService;
        private readonly IKupacService kupacService;
        private readonly UserManager<ApplicationUser> _userManager;
        public MobitelController(IMobitelService mobitelService, UserManager<ApplicationUser> userManager, IKomentarService komentarService, IKupacService kupacService)
        {
            this.mobitelService = mobitelService;
            this.komentarService = komentarService;
            this.kupacService = kupacService;
            _userManager = userManager;
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Customer");

            MobitelIndexViewModel model = new MobitelIndexViewModel();
            model.Mobitel = MobitelViewModel.ConvertToMobitelViewModel(mobitelService.GetMobitel(id.Value));
            model.Komentari = komentarService.GetAllKomentariByPhoneId(id.Value);

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Komentiraj(string komentar, int mobitelId)
        {
            if(komentar.IsNullOrEmpty() || komentar.Length > 1000)
            {
                ModelState.AddModelError("predugkomentar", "Vas komentar je predug, isti mora biti manji od 1000 karaktera.");
                MobitelIndexViewModel model = new MobitelIndexViewModel();
                model.Mobitel = MobitelViewModel.ConvertToMobitelViewModel(mobitelService.GetMobitel(mobitelId));
                model.Komentari = komentarService.GetAllKomentariByPhoneId(mobitelId);
                return View(model);
            }
            var userId = _userManager.GetUserId(HttpContext.User);
            int kupacId = kupacService.GetKupacByAspUserId(userId);
            komentarService.InsertKomentar(new Komentar { Datum = DateTime.UtcNow, KupacId = kupacId, Sadrzaj = komentar, MobitelId=mobitelId });
            return RedirectToAction("Index", new { id = mobitelId });
        }
    }
}
