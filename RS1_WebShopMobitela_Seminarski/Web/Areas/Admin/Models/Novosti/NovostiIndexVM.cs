using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class NovostiIndexVM
    {
        public int Id { get; set; }

        public string SadrzajTekst { get; set; }

        public string Naslov { get; set; }

        public DateTime Datum { get; set; }


        public static NovostiIndexVM ConvertToNovostiViewModel(Novosti x)
        {

            return new NovostiIndexVM
            {
                Id = x.Id,
                SadrzajTekst = x.SadrzajTekst,
                Naslov = x.Naslov,
                Datum = x.Datum

            };
        }

    }



   
}
