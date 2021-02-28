using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;
using Web.Areas.Customer.Helpers;
using Web.Areas.Customer.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MobitelController : Controller
    {
        IMobitelService mobitelService;

        private readonly IProizvodjacService proizvodjacService;
        private readonly IPopustiService popustiService;
        private readonly ISlikaService slikaService;
        private readonly IHostingEnvironment hostingEnvironment;


        public MobitelController(IMobitelService mobitelService,                                    
                                 IProizvodjacService proizvodjacService,
                                 IPopustiService popustiService,
                                 IHostingEnvironment hostingEnvironment,
                                 ISlikaService slikaService)
        {
            this.mobitelService = mobitelService;
            this.proizvodjacService = proizvodjacService;
            this.popustiService = popustiService;
            this.hostingEnvironment = hostingEnvironment;
            this.slikaService = slikaService;
        }

        

        public IActionResult Prikaz()
        {
            var mobiteli = mobitelService.GetMobiteli().Select(x => MobitelDetaljiVM.ConvertToMobitelViewModel(x)).ToList();

            return View(mobiteli);
        }

        public IActionResult Dodaj()
        {
            var model = new MobitelDodajVM
            {

            proizvodjaci = proizvodjacService.GetProizvodjaci().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Naziv }).Distinct().ToList(),
                
            popusti = popustiService.GetPopusti().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.PostotakPopusta.ToString() }).ToList(),
               
           

        };
            model.popusti.Insert(0, new SelectListItem { Value = null, Text = "Bez popusta", });
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(MobitelDodajVM model)
        {
            Mobiteli mobitel;

           

                //proizvodjacService.GetProizvodjaci().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Naziv }).Distinct().ToList();

            if (model.Id == 0)
            {
                //dodavanje
                mobitel = new Mobiteli();
                mobitelService.InsertMobitel(mobitel);

            }
            else
            {
                mobitel = mobitelService.GetMobitel(model.Id);
                //editiranje
            }
            

           
            
                   mobitel.Naziv = model.Naziv;
                   mobitel.DijagonalaEkrana = model.DijagonalaEkrana;
                   mobitel.Graficka = model.Graficka;
                   mobitel.Megapikseli = model.Megapikseli;
                   mobitel.PopustId = model.PopustId;
                   mobitel.Cijena = model.Cijena;//Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * (double)x.Popust.PostotakPopusta)) : x.Cijena),
                   mobitel.Procesor = model.Procesor;
                   mobitel.Ram_Gb = model.Ram_Gb;
                   mobitel.StanjeNaSkladistu = model.StanjeNaSkladistu;
                   mobitel.Tezina = model.Tezina;
                   mobitel.Rezolucija = model.Rezolucija;
                   mobitel.Opis = model.Opis;
                   mobitel.KratkiOpis = model.KratkiOpis;
                   mobitel.ProizvodjacId = model.ProizvodjacID;

                   string uniqueFileName = null;


            Slika slika;
            if (model.Photos != null)
            {
                slika = new Slika();
                string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Admin/images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photos.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                model.Photos.CopyTo(new FileStream(filePath, FileMode.Create));
                slika.Order = 1;
                slika.Path = uniqueFileName;
                slika.MobitelId = mobitel.Id;
                slikaService.InsertSlika(slika);
                
            }

            mobitelService.saveChanges2();
                    
            return RedirectToAction("Prikaz");
        }

        public IActionResult Edit(int id)
        {
            
            Mobiteli x = mobitelService.GetMobitel(id);

            MobitelDodajVM mobitel1 = MobitelDodajVM.ConvertToMobitelViewModel(x);
          

            mobitel1.proizvodjaci = proizvodjacService.GetProizvodjaci().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Naziv }).Distinct().ToList();
            mobitel1.popusti = popustiService.GetPopusti().Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.PostotakPopusta.ToString() }).ToList();
            //mobitel1.Photos = 

            mobitel1.popusti.Insert(0, new SelectListItem { Value = null, Text = "Bez popusta", });

            if (mobitel1 != null)
            {
                return View("Dodaj", mobitel1);
            }
            return RedirectToAction("Prikaz");
        }
        public IActionResult Detalji(int id)
        {

            MobitelDetaljiVM model = MobitelDetaljiVM.ConvertToMobitelViewModel(mobitelService.GetMobitel(id));
         
            return View("Detalji",model);
        }

        public IActionResult Delete(int id)
        {

            mobitelService.Delete(id);
            return RedirectToAction("Prikaz");
        }
      

    }
}
