using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NarudzbaController : Controller
    {
        INarudzbaService narudzbaService;

        IStavkeNarudzbeService stavkeNarudzbaService;



        public NarudzbaController(INarudzbaService narudzbaService, IStavkeNarudzbeService stavkeNarudzbaService)
        {
            this.narudzbaService = narudzbaService;
            this.stavkeNarudzbaService = stavkeNarudzbaService;
        }


        public IActionResult Prikaz()
        {
            var model = narudzbaService.GetNarudzbe2().Select(x => NarudzbaVM.ConvertToNarudzbaViewModel(x));
            
            return View(model);
        }
        public IActionResult Detalji(int Id)
        {
            var stavka = stavkeNarudzbaService.GetStavkeNarudzbe().Where(x => x.NarudzbaId == Id).ToList();


            var model = StavkeNarudzbeVM.ConvertToStavkeNarudzbeViewModel(stavka);


            return View("Detalji", model);
        }

        public IActionResult Obrisi(int Id)
        {
            var narudzba = narudzbaService.GetNarudzba(Id);
            narudzbaService.DeleteNarudzba(narudzba);

            return RedirectToAction("Prikaz");
        }
    }
}
