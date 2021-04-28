using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempReport
{
    public class ReportnarudzbeViewModel
    {
        public string ImeKupca { get; set; }
        public DateTime datum { get; set; }
        public string kanton { get; set; }
         public string grad { get; set; }
        public double cijena { get; set; }
       
        public static List<ReportnarudzbeViewModel> Get()
        {
            return new List<ReportnarudzbeViewModel> { };
        }
    }
}