﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
   // [Authorize(Roles = RolesEnums.Administrator)]
    [Area("Admin")]
    public class DobavljacController : Controller
    {
         IDobavljacService dobavljacService;

        public DobavljacController(IDobavljacService dobavljacService)
        {
            this.dobavljacService = dobavljacService;
        }

        public IActionResult Prikaz()
        {

            var model = dobavljacService.GetDobavljaci().Select(x => DobavljacPregledVM.ConvertToDobavljacViewModel(x)).ToList();

            return View(model);
        }

        public IActionResult Dodaj()
        {
            return View("SnimiDobavljac");
        }

        public IActionResult SnimiDobavljac(DobavljacPregledVM x)
        {

            if (!ModelState.IsValid)
            {
                
                return View("SnimiDobavljac", x);
            }
            Dobavljac dobavljac = new Dobavljac
            {
                Id = x.Id,
                Ime = x.Ime,
                Broj = x.Broj,
                Mail = x.Mail
            };
            dobavljacService.InsertDobavljac(dobavljac);

            return RedirectToAction("Prikaz");
        }

        public IActionResult Obrisi(int Id)
        {
            var dobavljac = dobavljacService.GetDobavljac(Id);
            dobavljacService.DeleteDobavljac(dobavljac);
            return RedirectToAction("Prikaz");
        }

        public IActionResult  Edit(int Id)
        {
            var dobavljac = dobavljacService.GetDobavljac(Id);
            var model = DobavljacPregledVM.ConvertToDobavljacViewModel(dobavljac);


            return View(model);
        }
        public IActionResult DobavljacEdit(DobavljacPregledVM x)
        {
            var dobavljac = dobavljacService.GetDobavljac(x.Id);

            dobavljac.Id = x.Id;
            dobavljac.Ime = x.Ime;
            dobavljac.Broj = x.Broj;
            dobavljac.Mail = x.Mail;

            dobavljacService.SaveChanges(dobavljac);

            return RedirectToAction("Prikaz");
        }

       
    }
}
