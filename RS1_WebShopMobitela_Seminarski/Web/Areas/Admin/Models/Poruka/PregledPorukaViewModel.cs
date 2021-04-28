using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class PregledPorukaViewModel
    {
        public int Id { get; set; }
        [Required]
        public string subjekt { get; set; }
        [Required]
        public string sadrzaj { get; set; }

        public  bool procitano { get; set; }
        public DateTime vrijemeslanja { get; set; }
        public string posiljateljId { get; set; }
        public List<SelectListItem> posiljatelji { get; set; }
        public string posiljatelj { get; set; }

        public string primateljId { get; set; }
        public List<SelectListItem> primatelji { get; set; }
        public string primatelj { get; set; }

        public string ImeZaposlenika { get; set; }
        public int zaposlenikId { get; set; }

        public string ImeAdmina { get; set; }
        public int adminId { get; set; }


        public static PregledPorukaViewModel ConvertToPorukaViewModel(Poruka x)
        {
            return new PregledPorukaViewModel
            {
                Id = x.Id,
                subjekt = x.Subjekt,
                sadrzaj = x.Sadrzaj,
                ImeZaposlenika = x.Zaposlenik.Ime,
                zaposlenikId = x.ZaposlenikId,
                vrijemeslanja = x.DatumSlanja,
                procitano = x.Procitano,
                ImeAdmina = x.Administrator.Ime,
                adminId = x.AdministratorId
            };
        }
    }
}
