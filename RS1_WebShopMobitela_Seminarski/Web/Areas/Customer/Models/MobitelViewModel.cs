using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Customer.Helpers;

namespace Web.Areas.Customer.Models
{
    public class MobitelViewModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public string Proizvodjac { get; set; }
        public string Opis { get; set; }
        public string KratkiOpis { get; set; }
        // cijena sa popustom ako popusta ima
        public double Cijena { get; set; }
        public bool Popust { get; set; }

        public string Megapikseli { get; set; }
        public string Ram_Gb { get; set; }

        public string Tezina { get; set; }
        public string Rezolucija { get; set; }
        public string DijagonalaEkrana { get; set; }
        public string Procesor { get; set; }
        public string Graficka { get; set; }
        public int StanjeNaSkladistu { get; set; }


        public List<string> Slike { get; set; }
        public static List<MobitelViewModel> ConvertToMobitelViewModel(IEnumerable<Mobiteli> mobiteli)
        {
            // cijena je sa popustom ako je popust true. 
            return mobiteli.Select(x =>
                new MobitelViewModel
                {
                    Id = x.Id,
                    Naziv = x.Naziv,
                    DijagonalaEkrana = x.DijagonalaEkrana.ToString(),
                    Graficka = x.Graficka,
                    Megapikseli = x.Megapikseli.ToString(),
                    Popust = x.PopustId != null,
                    Cijena = Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * (double)x.Popust.PostotakPopusta)) : x.Cijena),
                    Procesor = x.Procesor,
                    Ram_Gb = x.Ram_Gb.ToString(),
                    StanjeNaSkladistu = x.StanjeNaSkladistu,
                    Tezina = x.Tezina.ToString(),
                    Rezolucija = x.Rezolucija,
                    Slike = x.Slika.Select(x => x.Path).ToList(),
                    Opis = x.Opis,
                    KratkiOpis = x.KratkiOpis,
                    Proizvodjac = x.Prozivodjac.Naziv
                }
            ).ToList();
        }

        public static MobitelViewModel ConvertToMobitelViewModel(Mobiteli x)
        {
            // cijena je sa popustom ako je popust true. 
            return new MobitelViewModel
            {
                Id = x.Id,
                Naziv = x.Naziv,
                DijagonalaEkrana = x.DijagonalaEkrana.ToString(),
                Graficka = x.Graficka,
                Megapikseli = x.Megapikseli.ToString(),
                Popust = x.PopustId != null,
                Cijena = Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * x.Popust.PostotakPopusta)) : x.Cijena),
                Procesor = x.Procesor,
                Ram_Gb = x.Ram_Gb.ToString(),
                StanjeNaSkladistu = x.StanjeNaSkladistu,
                Tezina = x.Tezina.ToString(),
                Rezolucija = x.Rezolucija,
                Slike = x.Slika.Select(x => x.Path).ToList(),
                Opis = x.Opis,
                KratkiOpis = x.KratkiOpis,
                Proizvodjac = x.Prozivodjac.Naziv

            };
        }
    }


}
