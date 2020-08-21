using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MobitelController : Controller
    {
        IMobitelService mobitelService;

        public MobitelController(IMobitelService mobitelService)
        {
            this.mobitelService = mobitelService;
        }



        public IActionResult Prikaz()
        {
            var mobiteli = mobitelService.GetMobiteli().Select(x => MobitelDodajVM.ConvertToMobitelViewModel(x)).ToList();

            return View(mobiteli);
        }

        public IActionResult Dodaj()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Dodaj(MobitelDodajVM x)
        {
            Mobiteli mobitel = new Mobiteli
            {
                Id = x.Id,
                Naziv = x.Naziv,
                DijagonalaEkrana = 3.4f,
                Graficka = x.Graficka,
                Megapikseli = 12.2f,
                Popust = null,
                Cijena = x.Cijena,//Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * (double)x.Popust.PostotakPopusta)) : x.Cijena),
                Procesor = x.Procesor,
                Ram_Gb = 8,
                StanjeNaSkladistu = x.StanjeNaSkladistu,
                Tezina = 320,
                Rezolucija = x.Rezolucija,
                // Slike = x.Slika.Select(x => x.Path).ToList(),
                Opis = x.Opis,
                KratkiOpis = x.KratkiOpis,
                ProizvodjacId = 1
            };
            mobitelService.InsertMobitel(mobitel);

            return RedirectToAction("Prikaz");
        }
        public IActionResult Detalji(int id)
        {

            //MobitelDodajVM model = MobitelDodajVM.ConvertToMobitelViewModel(mobitelService.GetMobitel(id)); prva verzija

            MobitelDetaljiVM model = MobitelDetaljiVM.ConvertToMobitelViewModel(mobitelService.GetMobitel(id));
         
            return View(model);
        }

        public IActionResult Delete(int id)
        {

            mobitelService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
