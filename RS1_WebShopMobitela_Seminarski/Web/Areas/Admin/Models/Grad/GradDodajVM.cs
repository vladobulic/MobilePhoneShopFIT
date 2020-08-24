using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class GradDodajVM
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

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
