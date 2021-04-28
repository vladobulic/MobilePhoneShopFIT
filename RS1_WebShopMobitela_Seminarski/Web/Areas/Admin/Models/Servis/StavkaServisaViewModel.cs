using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class StavkaServisaViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ServisId { get; set; }
        [Required]
        public double cijena { get; set; }
        public string Ime { get; set; }
        public List<SelectListItem> komponente { get; set; }
        [Required]
        public int komponentaId { get; set; }
        public string nazivKomponente { get; set; }

            public static StavkaServisaViewModel ConvertToStavkaServisViewModel(StavkaServisa x)
        {


            // cijena je sa popustom ako je popust true. 
            return new StavkaServisaViewModel
            {
                cijena = x.Cijena,
                Ime = x.Ime,
                ServisId = x.ServisId,
                komponentaId = x.KomponenteId,
                nazivKomponente = x.Komponente.Ime
            };
        }
    }
}
