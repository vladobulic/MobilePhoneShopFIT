using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;
using Web.Areas.Customer.Helpers;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MobitelController : Controller
    {
        IMobitelService mobitelService;

        private readonly IProizvodjacService proizvodjacService;

        private readonly IPopustiService popustiService;

        public MobitelController(IMobitelService mobitelService, IProizvodjacService proizvodjacService, IPopustiService popustiService)
        {
            this.mobitelService = mobitelService;
            this.proizvodjacService = proizvodjacService;
            this.popustiService = popustiService;
        }

        

        public IActionResult Prikaz()
        {
            var mobiteli = mobitelService.GetMobiteli().Select(x => MobitelDetaljiVM.ConvertToMobitelViewModel(x)).ToList();

            return View(mobiteli);
        }

        public IActionResult Prikaz1()
        {
            var mobiteli = mobitelService.GetMobiteli().Select(x => MobitelDetaljiVM.ConvertToMobitelViewModel(x)).ToList();

            return View(mobiteli);
        }


        public IActionResult Dodaj()
        {
            var model = new MobitelDodajVM
            {

                proizvodjaci = proizvodjacService.GetProizvodjaci().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Naziv }).Distinct().ToList(),
                popusti = popustiService.GetPopusti().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.PostotakPopusta.ToString() }).ToList()
            //OpstineStavke = db.opstina.Select(o => new SelectListItem { Value = o.ID.ToString(), Text = o.Naziv }).ToList(),

        };

            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(MobitelDodajVM x)
        {
            Mobiteli mobitel;

           

                //proizvodjacService.GetProizvodjaci().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Naziv }).Distinct().ToList();

            if (x.Id ==0)
            {
                //dodavanje
                mobitel = new Mobiteli();
                mobitelService.InsertMobitel(mobitel);

            }
            else
            {
                mobitel = mobitelService.GetMobitel(x.Id);
                //editiranje
            }
                //mobitel.Id = x.Id;
                   mobitel.Naziv = x.Naziv;
                   mobitel.DijagonalaEkrana = x.DijagonalaEkrana;
                   mobitel.Graficka = x.Graficka;
                   mobitel.Megapikseli = x.Megapikseli;
                   mobitel.PopustId = x.PopustId;
                   mobitel.Cijena = x.Cijena;//Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * (double)x.Popust.PostotakPopusta)) : x.Cijena),
                   mobitel.Procesor = x.Procesor;
                   mobitel.Ram_Gb = x.Ram_Gb;
                   mobitel.StanjeNaSkladistu = x.StanjeNaSkladistu;
                   mobitel.Tezina = x.Tezina;
                   mobitel.Rezolucija = x.Rezolucija;
                    // Slike = x.Slika.Select(x => x.Path).ToList(),
                   mobitel.Opis = x.Opis;
                   mobitel.KratkiOpis = x.KratkiOpis;
                   mobitel.ProizvodjacId = x.ProizvodjacID;
                   

                    mobitelService.saveChanges2();         

            return RedirectToAction("Prikaz");
        }

        public IActionResult Edit(int id)
        {
            
            Mobiteli x = mobitelService.GetMobitel(id);

            MobitelDodajVM mobitel1 = MobitelDodajVM.ConvertToMobitelViewModel(x);
          

            mobitel1.proizvodjaci = proizvodjacService.GetProizvodjaci().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Naziv }).Distinct().ToList();
            mobitel1.popusti = popustiService.GetPopusti().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.PostotakPopusta.ToString() }).ToList();

            if (mobitel1 != null)
            {
                return View("Dodaj", mobitel1);
            }
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
            return RedirectToAction("Prikaz");
        }
      

    }
}
