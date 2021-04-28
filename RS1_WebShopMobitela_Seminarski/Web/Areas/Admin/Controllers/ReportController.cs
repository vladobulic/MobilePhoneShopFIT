using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempReport;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
        private readonly IKupacService kupacService;
        private readonly INarudzbaService narudzbaService;
        public ReportController(IKupacService kupacService, INarudzbaService narudzbaService)
        {
            this.kupacService = kupacService;
            this.narudzbaService = narudzbaService;
        }

        public  List<ReportKupciViewModel> getKupci()
        {
            
            List<ReportKupciViewModel> podaci = kupacService.GetKupci().Select(s => ReportKupciViewModel.ConvertTo(s)).ToList();
       
            return podaci;
        }
        

        public List<ReportnarudzbeViewModel> getNarudzbe()
        {
            List<ReportnarudzbeViewModel> podaci = narudzbaService.GetNarudzbe2().Select(s => new ReportnarudzbeViewModel
            {
                ImeKupca = s.Kupac.Ime + " " + s.Kupac.Prezime,
                datum = s.Datum,
                kanton = s.Kanton,
                grad = s.Kupac.Grad.Naziv,
                cijena = s.UkupnaCijena
    }).ToList();

            return podaci;
        }

        public IActionResult Index2()
        {
            LocalReport _localReport = new LocalReport("Reports/Report2.rdlc");
            List<ReportnarudzbeViewModel> podaci = getNarudzbe();

            _localReport.AddDataSource("DataSet1", podaci);

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("ReportSastavio", HttpContext.User.Identity.Name);

            //ReportResult result = _localReport.Execute(RenderType.ExcelOpenXml, parameters: parameters);
            //return File(result.MainStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");


            ReportResult result = _localReport.Execute(RenderType.Pdf, parameters: parameters);
            return File(result.MainStream, "application/pdf");

        }

        public IActionResult Index()
        {
            LocalReport _localReport = new LocalReport("Reports/Report1.rdlc");
            List<ReportKupciViewModel> podaci = getKupci();
            
            _localReport.AddDataSource("DataSet1", podaci);

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("ReportSastavio", HttpContext.User.Identity.Name);

            //ReportResult result = _localReport.Execute(RenderType.ExcelOpenXml, parameters: parameters);
            //return File(result.MainStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");


            ReportResult result = _localReport.Execute(RenderType.Pdf, parameters: parameters);
            return File(result.MainStream, "application/pdf");

        }
    }
}
