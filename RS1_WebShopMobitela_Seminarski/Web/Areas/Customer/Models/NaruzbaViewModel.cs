using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Models
{
    public class NaruzbaViewModel
    {

        public KosaricaIndexViewModel Detalji { get; set; }

        [Required(ErrorMessage = "Morate unjeti kontakt telefon")]
        public string KontaktTelefon { get; set; }

        [Required(ErrorMessage = "Morate unjeti kanton")]
        public string Kanton { get; set; }

        [Required(ErrorMessage = "Morate unjeti opcinu")]
        public string Opcina { get; set; }

        [Required(ErrorMessage = "Morate unjeti ulicu")]
        public string Ulica { get; set; }

        [Required(ErrorMessage = "Morate unjeti postanski broj")]
        public string PostanskiBroj { get; set; }


    }
}
