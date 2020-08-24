using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class DobavljacPregledVM
    {
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Broj { get; set; }

        public string Mail { get; set; }


       public static DobavljacPregledVM ConvertToDobavljacViewModel(Dobavljac x)
        {
            return new DobavljacPregledVM
            {
                Id = x.Id,
                Ime = x.Ime,
                Broj = x.Broj,
                Mail = x.Mail
            };
        }
    }
}
