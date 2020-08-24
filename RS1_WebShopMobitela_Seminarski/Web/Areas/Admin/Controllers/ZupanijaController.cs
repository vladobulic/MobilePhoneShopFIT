using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ZupanijaController : Controller
    {

        IZupanijaService zupanijaService;

        public ZupanijaController(IZupanijaService zupanijaService)
        {
            this.zupanijaService = zupanijaService;
        }

        public IActionResult Prikaz()
        {
            var zupanije = zupanijaService.GetZupanije().Select(x => ZupanijaPregledVM.ConvertToZupanijaViewModel(x)).ToList();
            return View(zupanije);
        }

        public IActionResult Dodaj()
        {
            return View("SnimiZupanija");
        }

        public IActionResult SnimiZupanija(ZupanijaPregledVM x)
        {
            var zupanija = zupanijaService.GetZupanija(x.Id);
            zupanija = new Zupanija
            {
                Id = x.Id,
                Naziv = x.Naziv
            };
            zupanijaService.InsertZupanija(zupanija);

            return RedirectToAction("Prikaz");
        }
        public IActionResult Obrisi(int Id)
        {
            var zupanija = zupanijaService.GetZupanija(Id);
            zupanijaService.DeleteZupanija(zupanija);

            var model = zupanija.Naziv;
            return View("ObrisiPoruka", model);
        }

        public IActionResult Edit(int Id)
        {
            var zupanija = zupanijaService.GetZupanija(Id);
            var model = ZupanijaPregledVM.ConvertToZupanijaViewModel(zupanija);

            return View(model);
        }

        public IActionResult EditZupanija(ZupanijaPregledVM x)
        {
            var zup = zupanijaService.GetZupanija(x.Id);
            zup.Id = x.Id;
            zup.Naziv = x.Naziv;
            zupanijaService.SaveChanges(zup);
            return RedirectToAction("Prikaz");
        }
    }
}
