﻿using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Required(ErrorMessage = "Morate unjeti ime")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Morate unjeti prezime")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Morate unjeti kontakt telefon")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(06)\d\s*\d{3}\s*\d{3}", ErrorMessage = "Format vaseg broja nije dobar, probajte sa 06X XXX XXX")]
        public string KontaktTelefon { get; set; }
        public string FullPhone { get; set; }

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
