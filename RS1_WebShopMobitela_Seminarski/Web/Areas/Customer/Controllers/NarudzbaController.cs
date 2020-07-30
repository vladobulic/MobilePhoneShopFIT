using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nexmo.Api;
using ServiceLayer.Classes.Helper;
using ServiceLayer.Interfaces;
using Web.Areas.Customer.Helpers;
using Web.Areas.Customer.Models;

namespace Web.Areas.Customer.Controllers
{
    
    [Area("Customer")]
    public class NarudzbaController : Controller
    {
        private static readonly string CartName = "cart";
        private readonly IMobitelService mobitelService;
        private readonly INarudzbaService narudzbaService;
        private readonly IKupacService kupacService;
        private readonly ISmsService smsService;
        private readonly UserManager<ApplicationUser> _userManager;
        public IConfiguration Configuration { get; set; }


        public NarudzbaController(IMobitelService mobitelService, INarudzbaService narudzbaService, UserManager<ApplicationUser> _userManager, IKupacService kupacService, ISmsService smsService, IConfiguration config)
        {
            this.mobitelService = mobitelService;
            this.narudzbaService = narudzbaService;
            this.kupacService = kupacService;
            this._userManager = _userManager;
            this.smsService = smsService;
            this.Configuration = config;

        }

        public IActionResult Index()
        {
            NaruzbaViewModel returnModel = new NaruzbaViewModel();
            PopulateModel(ref returnModel);
            return View(returnModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(NaruzbaViewModel model)
        {
            NaruzbaViewModel returnModel = new NaruzbaViewModel();
            PopulateModel(ref returnModel);

            if (!ModelState.IsValid)
            {
                
                return View(returnModel);
            }


            Narudzba narudzba = new Narudzba
            {
                Datum = DateTime.UtcNow,
                Kanton = model.Kanton,
                Ulica = model.Ulica,
                KontaktTelefon = model.KontaktTelefon,
                PostanskiBroj = model.PostanskiBroj,
                UkupnaCijena = returnModel.Detalji.TotalPrice,
                Stanje = 1,
                KupacId = kupacService.GetKupacByAspUserId(_userManager.GetUserId(HttpContext.User)),
                Opcina = model.Opcina
                
            };

            List<StavkaNarudzbe> listaStavki = new List<StavkaNarudzbe>();
            foreach (var item in returnModel.Detalji.Items)
            {
                var stavka = new StavkaNarudzbe
                {
                    MobitelId = item.Product.Id,
                    Kolicina = item.Quantity,
                    Cijena = item.Product.mobitel.Cijena
                };
                listaStavki.Add(stavka);
            }

            
            narudzbaService.InsertNarudzba(narudzba, listaStavki);

            // posalji sms zahvale kupcu
            string poruka = "Hvala vam na naruzbi sa webshopmobitela, " + model.Ime + ".Vasa naruzba ce ubrzo biti dostavljena u ulicu " + model.Ulica+".";
            
            smsService.SendSms(new SmsModel { To = model.FullPhone, Text =  poruka});


            // nakon uspjesne narudzbe ukloni sve iz kosarice.
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName);
           
            cart.RemoveAll(x => x.Quantity > 0);
            SessionHelper.SetObjectAsJson(HttpContext.Session, CartName, cart);
            

            return RedirectToAction("Narudzbe");
        }



        public ActionResult Narudzbe() {

            return View(narudzbaService.GetNarudzbe(_userManager.GetUserId(HttpContext.User)));
        }




        private void PopulateModel(ref NaruzbaViewModel returnModel)
        {
            KosaricaIndexViewModel model = new KosaricaIndexViewModel();
            model.TotalPrice = 0;
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName);

            // get all of the data for display view and calculate the total price of the phone
            foreach (var item in cart)
            {
                var mobitel = mobitelService.GetMobitel(item.Product.Id);

                item.Product.mobitel = MobitelViewModel.ConvertToMobitelViewModel(mobitel);
                model.TotalPrice += Converter.RoundToTwoDecimal(item.Product.mobitel.Cijena * item.Quantity);
            }
            model.Items = cart;

            returnModel.Detalji = model;
        }
    }
}
