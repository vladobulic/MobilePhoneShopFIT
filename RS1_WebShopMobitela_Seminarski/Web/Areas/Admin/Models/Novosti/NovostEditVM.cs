using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class NovostEditVM
    {
        public int Id { get; set; }

        public string SadrzajTekst { get; set; }

        public string Naslov { get; set; }

        public DateTime Datum { get; set; }

        public int ZaposlenikId { get; set; }

        public static NovostEditVM ConvertToNovostiViewModel(Novosti x)

        {
            return new NovostEditVM
            {
                Id = x.Id,
                SadrzajTekst = x.SadrzajTekst,
                Naslov = x.Naslov,
                Datum = x.Datum,
                ZaposlenikId = x.ZaposlenikId
            };
        }

        
    }
}
