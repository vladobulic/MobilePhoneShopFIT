using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KomponenteController : Controller
    {

        IKomponenteService komponenteService;

        ITipKomponenteService tipKomponenteService;

        IDobavljacService dobavljacService;

        public KomponenteController(IKomponenteService komponenteService, ITipKomponenteService tipKomponenteService, IDobavljacService dobavljacService)
        {
            this.komponenteService = komponenteService;
            this.tipKomponenteService = tipKomponenteService;
            this.dobavljacService = dobavljacService;
        }

        public IActionResult Prikaz()
        {
            var model = komponenteService.GetKomponente().Select(x => KomponentePregledVM.ConvertToKomponenteViewModel(x)).ToList();

            return View(model);
        }
        public IActionResult Dodaj()
        {
            var model = new KomponentePregledVM
            {
                tipovikomponente = tipKomponenteService.GetTipKomponente().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }).ToList(),
                 dobavljaci = dobavljacService.GetDobavljaci().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Ime }).ToList()
            };

            return View(model);
        }
        public IActionResult SnimiDobavljac(KomponentePregledVM x)
        {
            Komponente komp = new Komponente
            {
                Id = x.Id,
                Ime = x.Ime,
                KolicinaNaSkladistu = x.KolicinaNaSkladistu,
                PreporucenaCijena = x.PreporucenaCijena,
                DobavljacID = x.DobavljacID,
                TipKomponenteId = x.TipKomponenteId
            };
            komponenteService.InsertKomponenta(komp);

            return RedirectToAction("Prikaz");
        }
        public IActionResult Obrisi(int Id)
        {
            var komp = komponenteService.Get(Id);

            komponenteService.DeleteKomponenta(komp);

            return RedirectToAction("Prikaz");
        }
        public IActionResult Edit(int Id)
        {
            var komponenta = komponenteService.Get(Id);
            var model = KomponentePregledVM.ConvertToKomponenteViewModel(komponenta);


            model.tipovikomponente = tipKomponenteService.GetTipKomponente().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }).ToList();
            model.dobavljaci = dobavljacService.GetDobavljaci().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Ime }).ToList();
            

            return View(model);
        }
        public IActionResult KomponenteEdit(KomponentePregledVM x)
        {
            var komponenta = komponenteService.Get(x.Id);
            komponenta.Id = x.Id;
            komponenta.Ime = x.Ime;
            komponenta.KolicinaNaSkladistu = x.KolicinaNaSkladistu;
            komponenta.PreporucenaCijena = x.PreporucenaCijena;
            komponenta.DobavljacID = x.DobavljacID;
            komponenta.TipKomponenteId = x.TipKomponenteId;

            komponenteService.SaveChanges(komponenta);

            return RedirectToAction("Prikaz");
        }
    }
}
