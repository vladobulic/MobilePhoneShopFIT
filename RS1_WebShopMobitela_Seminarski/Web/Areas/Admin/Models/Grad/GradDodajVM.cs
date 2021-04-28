using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nexmo.Api.Voice.EventWebhooks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class GradDodajVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to enter the title.")]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Naziv { get; set; }

        [Range(1, int.MaxValue, ErrorMessage ="Morate unijeti postanksi borj")]
        public int PostanskiBroj { get; set; }

        public int ZupanijaId { get; set; }


        public List<SelectListItem> zupanije { get; set; }


        public static GradDodajVM convertToGradDodajViewModel(Grad x)
        {
            return new GradDodajVM
            {
                Id = x.Id,
                Naziv = x.Naziv,
                PostanskiBroj = x.PostanskiBroj,
                ZupanijaId = x.ZupanijaId
            };
        }

    }
}
