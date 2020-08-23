using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class NovostiDodajVM
    {
        public int Id { get; set; }

        public string SadrzajTekst { get; set; }

        public string Naslov { get; set; }

        public DateTime Datum { get; set; }

        public int ZaposlenikId { get; set; }



    }



   
}
