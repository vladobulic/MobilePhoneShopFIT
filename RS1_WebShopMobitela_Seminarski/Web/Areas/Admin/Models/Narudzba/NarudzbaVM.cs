using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class NarudzbaVM
    {
        public int Id { get; set; }

        public double UkupnaCijena { get; set; }

        public DateTime Datum { get; set; }


        // 1 = Obrada, 2 = Posiljka poslana
        public int Stanje { get; set; }

        public string KontaktTelefon { get; set; }

    

        public virtual List<StavkeNarudzbeVM> stavkeNarudzbe { get; set; }
        // koji je kupac narucio ako je kupac bio logiran
        public int KupacId { get; set; }
        public string kupac { get; set; }
        
        public string Opcina { get; set; }
        public string Kanton { get; set; }
        public string PostanskiBroj { get; set; }
        public string Ulica { get; set; }

        public int? ZaposlenikId { get; set; }
        public string zaposlenik { get; set; }

        public static NarudzbaVM ConvertToNarudzbaViewModel(Narudzba x)
        {
            return new NarudzbaVM
            {
                Id = x.Id,
                UkupnaCijena = x.UkupnaCijena,
                Datum = x.Datum,
                Stanje = x.Stanje,
                KontaktTelefon = x.KontaktTelefon,
                KupacId = x.KupacId,
                Opcina = x.Opcina,
                Kanton = x.Kanton,
                PostanskiBroj = x.PostanskiBroj,
                Ulica  = x.Ulica,
                ZaposlenikId = x.ZaposlenikId,
                zaposlenik = x.Zaposlenik.Ime + " " + x.Zaposlenik.Prezime,
                kupac = x.Kupac.Ime + " " + x.Kupac.Prezime
            };
        }
        
    }
}
