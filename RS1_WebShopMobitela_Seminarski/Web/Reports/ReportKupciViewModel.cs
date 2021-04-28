using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempReport
{
    public class ReportKupciViewModel
    {
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string BrojMobitela { get; set; }
       public string grad { get; set; }
       
        public static ReportKupciViewModel ConvertTo(Kupac x)
        {
            return new ReportKupciViewModel
            {
                ImePrezime = x.Ime + " " + x.Prezime,
                Email = x.Email,
                BrojMobitela = x.BrojMobitela,
                grad = x.Grad.Naziv
            };
        }

        public static List<ReportKupciViewModel> Get()
        {
            return new List<ReportKupciViewModel> { };
        }
    }
}