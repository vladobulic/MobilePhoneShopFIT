using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KupacController : Controller
    {
        private readonly IKupacService kupacService;
        private readonly IBannedKupacService bannedKupacService;
        private readonly IKomentarService komentarService;

        public KupacController(IKupacService kupacService, IBannedKupacService bannedKupacService, IKomentarService komentarService)
        {
            this.kupacService = kupacService;
            this.bannedKupacService = bannedKupacService;
            this.komentarService = komentarService;
        }
        
        public IActionResult Index()
        {
            var kupci = kupacService.GetKupci().Select(x => KupacPregledViewModel.ConvertToKupacViewModel(x)).ToList();
            return View(kupci);
        }

        [HttpGet]
        public IActionResult BanKupca(int id)
        {
            BanKupcaViewModel model = new BanKupcaViewModel
            {
                Id = id
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult BanKupca(BannedKupac model)
        {
            if(ModelState.IsValid)
            {
                BannedKupac bannedKupac = new BannedKupac
                {
                    DatumDo = model.DatumDo,
                    Razlog = model.Razlog,
                    Zauvijek = model.Zauvijek
                };
                bannedKupacService.InsertBannedKupac(bannedKupac);

                Kupac ban = kupacService.GetKupac(model.Id);
                ban.BannedKupacId = bannedKupac.Id;
                kupacService.SaveChanges(ban);

                return RedirectToAction("Index");
            }
         
          

            
            return View(model);
        }
        
        public IActionResult SviKomentari()
        {
            var komentari = komentarService.GetKomentari().Select(x => KomentariPregledViewModel.ConvertToKomentariPregledViewModel(x)).ToList();
            return View(komentari);
        }


        public IActionResult ObrisiKomentar(int id)
        {
            Komentar komentar = komentarService.GetKomentar(id);
            komentar.IsDeleted = true;
            komentarService.SaveChanges(komentar);
            return RedirectToAction("SviKomentari");
        }
    }
}
