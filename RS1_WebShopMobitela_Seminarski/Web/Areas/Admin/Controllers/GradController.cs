using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;


namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GradController : Controller
    {
        IGradoviService gradoviService;

        IZupanijaService zupanijeService;

        public GradController(IGradoviService gradoviService, IZupanijaService zupanijeService)
        {
            this.gradoviService = gradoviService;
            this.zupanijeService = zupanijeService;
        }
    
       public IActionResult Dodaj()
        {
            GradDodajVM model = new GradDodajVM();
            model.zupanije = zupanijeService.GetZupanije().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }).ToList();



            return View("SnimiGrad", model);
        }

        public IActionResult SnimiGrad(GradDodajVM x)
        {

            if (!ModelState.IsValid)
            {
                x.zupanije = zupanijeService.GetZupanije().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }).ToList();
                return View("SnimiGrad", x);
            }
            Grad grad = new Grad
            {
               Id = x.Id,
               Naziv = x.Naziv,
               PostanskiBroj = x.PostanskiBroj,
               ZupanijaId = x.ZupanijaId
            };
            gradoviService.InsertGrad(grad);
          
            return RedirectToAction("Index");
        }
        public IActionResult Obrisi(int Id)
        {
            Grad grad = gradoviService.GetGrad(Id);

            gradoviService.DeleteGrad(grad);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {

            var model = gradoviService.GetGradovi().Select(x => GradPregledVM.convertToGradDodajViewModel(x)).ToList();

            return View("Index",model);
        }

        public IActionResult Edit(int Id)
        {
            Grad grad = gradoviService.GetGrad(Id);
            GradDodajVM model = GradDodajVM.convertToGradDodajViewModel(grad);

            model.zupanije = zupanijeService.GetZupanije().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Naziv }).ToList();
            
            return View(model);
        }

        public IActionResult EditGrad(GradDodajVM x)
        {
            Grad grad = gradoviService.GetGrad(x.Id);
            grad.Id = x.Id;
            grad.Naziv = x.Naziv;
            grad.PostanskiBroj = x.PostanskiBroj;
            grad.ZupanijaId = x.ZupanijaId;

            gradoviService.SaveChanges(grad);

            return RedirectToAction("Index");
        }
    }
}
