using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Customer.Helpers;

namespace Web.Areas.Admin.Models
{
    public class MobitelDodajVM
    {

        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }

        public int? ProizvodjacID { get; set; }

        public List<SelectListItem> proizvodjaci { get; set; }

        public int? PopustId { get; set; }
        public List<SelectListItem> popusti { get; set; }
        [Required]
        public string Opis { get; set; }
        public string KratkiOpis { get; set; }
        // cijena sa popustom ako popusta ima
        [Required]
        public double Cijena { get; set; }
        
        

        public float Megapikseli { get; set; }
        public float Ram_Gb { get; set; }
      
        
        public int Tezina { get; set; }
        public string Rezolucija { get; set; }
        public float DijagonalaEkrana { get; set; }
        public string Procesor { get; set; }
        public string Graficka { get; set; }
        public int StanjeNaSkladistu { get; set; }
        public IFormFile Photos { get;set; }



      

        public static MobitelDodajVM ConvertToMobitelViewModel(Mobiteli x)
        {
            //int? Id;
            //if (x.Popust != null)
            //{
            //    Id = x.PopustId;
            //}
            //else
            //{
            //    Id = x.PopustId;
            //}
            // cijena je sa popustom ako je popust true. 
            return new MobitelDodajVM
            {
                Id = x.Id,
                Naziv = x.Naziv,
                DijagonalaEkrana = x.DijagonalaEkrana,
                Graficka = x.Graficka,
                Megapikseli = x.Megapikseli,
                PopustId = x.PopustId,
                Cijena = Converter.RoundToTwoDecimal(x.PopustId != null ? (x.Cijena - (x.Cijena * x.Popust.PostotakPopusta)) : x.Cijena),
                Procesor = x.Procesor,
                Ram_Gb = x.Ram_Gb,
                StanjeNaSkladistu = x.StanjeNaSkladistu,
                Tezina = x.Tezina,
                Rezolucija = x.Rezolucija,
                Opis = x.Opis,
                KratkiOpis = x.KratkiOpis,
                ProizvodjacID = x.ProizvodjacId,


            // proizvodjaci = 


        };
        }
    }

}
