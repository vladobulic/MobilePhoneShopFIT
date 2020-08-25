using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class TipKomponenteController : Controller
    {
        ITipKomponenteService tipKomponenteService;

        public TipKomponenteController(ITipKomponenteService tipKomponenteService)
        {
            this.tipKomponenteService = tipKomponenteService;
        }

        public IActionResult Prikaz()
        {
            var model = tipKomponenteService.GetTipKomponente().Select(x => TipKomponenteVM.ConvertToTipKomponenteViewModel(x));
            return View(model);
        }

        public IActionResult Dodaj()
        {
            
            return View();
        }

        public IActionResult SnimiTipKomponente(TipKomponente x)
        {
            TipKomponente tip = new TipKomponente
            {
                Id = x.Id,
                Naziv = x.Naziv
            };

            tipKomponenteService.InsertTipKomponenta(tip);

            return RedirectToAction("Prikaz");
        }

        public IActionResult Obrisi(int Id)
        {
            var tip = tipKomponenteService.Get(Id);
            tipKomponenteService.DeleteTipKomponenta(tip);
            return RedirectToAction("Prikaz");
        }
        public IActionResult Edit(int Id)
        {
            var tip = tipKomponenteService.Get(Id);
            var model = TipKomponenteVM.ConvertToTipKomponenteViewModel(tip);
            return View(model);
        }
      

        public IActionResult TipKomponenteEdit(TipKomponenteVM x)
        {
            var tip = tipKomponenteService.Get(x.Id);

            tip.Id = x.Id;
            tip.Naziv = x.Naziv;
            tipKomponenteService.SaveChanges(tip);
            return RedirectToAction("Prikaz");
        }
    }
}
