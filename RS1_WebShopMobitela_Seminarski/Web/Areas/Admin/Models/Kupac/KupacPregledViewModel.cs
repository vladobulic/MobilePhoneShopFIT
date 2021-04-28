using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class KupacPregledViewModel
    {   
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string brojMobitela { get; set; }
        public string grad { get; set; }


        public static KupacPregledViewModel ConvertToKupacViewModel(Kupac x)
        {
            return new KupacPregledViewModel
            {
                Id = x.Id,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Email = x.Email,
                brojMobitela = x.BrojMobitela,
                grad = x.Grad.Naziv
            };
        }
    }
}
