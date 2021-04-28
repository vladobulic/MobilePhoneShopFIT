using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Customer.Helpers;

namespace Web.Areas.Admin.Models
{
    public class MobitelDetaljiVM
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public int? ProizvodjacId { get; set; }
        public string Proizvodjac { get; set; }

        public string Opis { get; set; }
        public string KratkiOpis { get; set; }
        // cijena sa popustom ako popusta ima
        public double Cijena { get; set; }
        public int? PopustId { get; set; }
        public List<SelectListItem> popusti { get; set; }
         public string popustiPrikaz { get; set; }
        public string Megapikseli { get; set; }
        public string Ram_Gb { get; set; }

        public string Tezina { get; set; }
        public string Rezolucija { get; set; }
        public string DijagonalaEkrana { get; set; }
        public string Procesor { get; set; }
        public string Graficka { get; set; }
        public int StanjeNaSkladistu { get; set; }
        public string PhotoPath { get; set; }




        //public static List<MobitelDetaljiVM> ConvertToMobitelViewModel(IEnumerable<Mobiteli> mobiteli)
        //{
        //    // cijena je sa popustom ako je popust true. 
        //    return mobiteli.Select(x =>
        //        new MobitelDetaljiVM
        //        {
        //            Id = x.Id,
        //            Naziv = x.Naziv,
        //            DijagonalaEkrana = x.DijagonalaEkrana.ToString(),
        //            Graficka = x.Graficka,
        //            Megapikseli = x.Megapikseli.ToString(),
        //            PopustId = x.PopustId,
        //            Cijena = Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * (double)x.Popust.PostotakPopusta)) : x.Cijena),
        //            Procesor = x.Procesor,
        //            Ram_Gb = x.Ram_Gb.ToString(),
        //            StanjeNaSkladistu = x.StanjeNaSkladistu,
        //            Tezina = x.Tezina.ToString(),
        //            Rezolucija = x.Rezolucija,
        //            PhotoPath = x.Slika.Select(x => x.Path).FirstOrDefault(),
        //            Opis = x.Opis,
        //            KratkiOpis = x.KratkiOpis
        //            //Proizvodjac = x.Prozivodjac.Naziv
        //        }
        //    ).ToList();
        //}

        public static MobitelDetaljiVM ConvertToMobitelViewModel(Mobiteli x)
        {
            float prikaz = 0;
            
            if (x.Popust != null)
            {
                prikaz = x.Popust.PostotakPopusta;
            }
            
            // cijena je sa popustom ako je popust true. 
            return new MobitelDetaljiVM
            {
                Id = x.Id,
                Naziv = x.Naziv,
                DijagonalaEkrana = x.DijagonalaEkrana.ToString(),
                Graficka = x.Graficka,
                Megapikseli = x.Megapikseli.ToString(),
                PopustId = x.PopustId,
                Cijena = Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * x.Popust.PostotakPopusta)) : x.Cijena),
                Procesor = x.Procesor,
                Ram_Gb = x.Ram_Gb.ToString(),
                StanjeNaSkladistu = x.StanjeNaSkladistu,
                Tezina = x.Tezina.ToString(),
                Rezolucija = x.Rezolucija,
                Opis = x.Opis,
                PhotoPath = x.Slika.Select(x => x.Path).FirstOrDefault(),
                KratkiOpis = x.KratkiOpis,
                ProizvodjacId = x.ProizvodjacId,
                Proizvodjac = x.Prozivodjac.Naziv,
                popustiPrikaz = prikaz * 100 + "%".ToString(),
            };
        }
    }
}
