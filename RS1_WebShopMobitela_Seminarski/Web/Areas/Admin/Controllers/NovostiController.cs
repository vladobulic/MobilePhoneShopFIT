using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;


namespace Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class NovostiController : Controller
    {

        INovostiService novostiService;

        public NovostiController(INovostiService novostiService)
        {
            this.novostiService = novostiService;
        }

        public IActionResult Index()
        {
            var model = novostiService.GetNovosti().Select(x => NovostiIndexVM.ConvertToNovostiViewModel(x)).ToList();
            

            return View(model);
        }
        public IActionResult Dodaj()
        {

            return View();
        }

        public IActionResult SnimiNovost(NovostiDodajVM x)
        {
            Novosti novost = new Novosti();

            novost.Naslov = x.Naslov;
            novost.SadrzajTekst = x.SadrzajTekst;
            novost.Datum = x.Datum;
            novost.ZaposlenikId = x.ZaposlenikId;
            

            novostiService.InsertNovost2(novost);
           

            return RedirectToAction("Index");
        }
        public IActionResult Obrisi(int Id)
        {
            var novosti = novostiService.GetNovost(Id);
            novostiService.ObrisiNovost(novosti);
            return RedirectToAction("ObrisiPoruka");
        }
        public IActionResult ObrisiPoruka()
        {

            return View("ObrisiPoruka");
        }


            public IActionResult EditNovost(int Id)
        {
            Novosti novost = novostiService.GetNovost(Id);
            NovostEditVM novost1 = NovostEditVM.ConvertToNovostiViewModel(novost);
            return View(novost1);
        }


        public IActionResult SaveEditNovost(NovostEditVM x)
        {
            Novosti novost1 = novostiService.GetNovost(x.Id);
            novost1.Id = x.Id;
            novost1.Naslov = x.Naslov;
            novost1.SadrzajTekst = x.SadrzajTekst;
            novost1.Datum = x.Datum;
            novost1.ZaposlenikId = x.ZaposlenikId;

            novostiService.SaveChanges(novost1);

            return RedirectToAction("Index");
        }


    }
}
