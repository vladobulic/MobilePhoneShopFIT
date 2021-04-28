using Vonage.Messaging;
using Vonage.Request;
using Microsoft.Extensions.Configuration;
using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServisController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        private readonly IServisService servisService;
        private readonly IStavkaServisService stavkaServisService;
        private readonly IZaposlenikService zaposlenikService;
        private readonly IKomponenteService komponenteService;
        public IConfiguration Configuration { get; set; }
        public ServisController(RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager, IServisService servisService, IStavkaServisService stavkaServisService, IZaposlenikService zaposlenikService,
            IKomponenteService komponenteService, IConfiguration config)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.servisService = servisService;
            this.stavkaServisService = stavkaServisService;
            this.zaposlenikService = zaposlenikService;
            this.komponenteService = komponenteService;
            Configuration = config;
        }

        public IActionResult Index()
        {

            
           var servisi = servisService.GetServisi().Select(x => DodajServisViewModel.ConvertToServisViewModel(x)).ToList();

            return View(servisi);
        }
       
        [HttpGet]
       public IActionResult IzmjenuStatusSms(int id)
        {
            IzmjenaStatusaViewModel model = new IzmjenaStatusaViewModel
            {
                ServisId = id
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult IzmjenuStatusSms(IzmjenaStatusaViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                if (model.ServisId != 0)
                {
                    Servis servis = servisService.GetServis(model.ServisId);
                    servis.StanjeServisa = 1;
                    servisService.SaveChanges(servis);
                }


                try
                {
                    string VONAGE_API_KEY = Configuration["VONAGE_API_KEY"];
                    var VONAGE_API_SECRET = Configuration["VONAGE_API_SECRET"];
                    var credentials = Credentials.FromApiKeyAndSecret(VONAGE_API_KEY, VONAGE_API_SECRET);
                    var client = new SmsClient(credentials);
                    string text = "Servis vaseg mobitela je zavrsen, poslat cemo ga na vasu adresu.";
                    string brojFrom = "38763953957";
                    var request = new SendSmsRequest { To = model.To, From = brojFrom, Text = text };
                    var response = client.SendAnSms(request);
                    ViewBag.MessageId = response.Messages[0].MessageId;
                }
                catch (VonageSmsResponseException ex)
                {
                    ViewBag.Error = ex.Message;
                }
                return View("IzmjeniStatus");
            }
            return View(model);
        }

        public IActionResult DetaljiServisa(int id)
        {
            var Stavkeservisa = stavkaServisService.GetStavke().Where(w=>w.ServisId == id).Select(x => StavkaServisaViewModel.ConvertToStavkaServisViewModel(x)).ToList();

            return View(Stavkeservisa);
        }


        [HttpGet]
        public IActionResult DodajServis()
        {
            DodajServisViewModel model = new DodajServisViewModel()
            {
                zaposlenici = zaposlenikService.GetZaposlenici()
                                         .Select(i => new SelectListItem()
                                         {
                                             Text = i.Email.ToString(),
                                             Value = i.Id.ToString()
                                         }).ToList()
            };

            return View(model);

        }


        [HttpPost]
        public IActionResult DodajServis(DodajServisViewModel model)
        {
            if(ModelState.IsValid)
            {
                Servis servis = new Servis
                {
                    DatumPrijema = model.DatumPrijema,
                    DatumZavrsetka = model.DatumZavrsetka,
                    Opis = model.Opis,
                    CijenaUkupno = model.CijenaUkupno,
                    ZaposlenikId = model.ZaposlenikId,
                    StanjeServisa = 0,
                };

                servisService.InsertServis(servis);
                return RedirectToAction("Index");
            }

            return View(model);
            
        }

        [HttpGet]
        public IActionResult DodajStavke(int id)
        {
           StavkaServisaViewModel model = new StavkaServisaViewModel()
            {
                ServisId = id,
                komponente = komponenteService.GetKomponente()
                                     .Select(i => new SelectListItem()
                                     {
                                         Text = i.Ime.ToString(),
                                         Value = i.Id.ToString()
                                     }).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult DodajStavke(StavkaServisaViewModel model)
        {
            StavkaServisa stavka = new StavkaServisa
            {
                Cijena = model.cijena,
                Ime = model.Ime,
                ServisId = model.ServisId,
                KomponenteId = model.komponentaId
            };
            stavkaServisService.InsertStavka(stavka);

            return RedirectToAction("index");
        }

    }
}
