using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class KomentariPregledViewModel
    {
        public int Id { get; set; }
        public string sadrzaj { get; set; }
        public DateTime datum { get; set; }
        public int mobitelId { get; set; }
        public int kupacId { get; set; }
        public bool isDeleted { get; set; }
        public string imeKupca { get; set; }
        public string nazivMobitela { get; set; }


        public static KomentariPregledViewModel ConvertToKomentariPregledViewModel(Komentar x)
        {
            return new KomentariPregledViewModel
            {
                Id = x.Id,
                isDeleted = x.IsDeleted,
                sadrzaj = x.Sadrzaj,
                datum = x.Datum,
                nazivMobitela = x.Mobitel.Naziv,
                mobitelId = x.Mobitel.Id,
                kupacId = x.Kupac.Id,
                imeKupca = x.Kupac.Ime + " " + x.Kupac.Prezime
            };
        }
    }


    
}
