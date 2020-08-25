using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class DobavljacPregledVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to enter the title.")]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
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
