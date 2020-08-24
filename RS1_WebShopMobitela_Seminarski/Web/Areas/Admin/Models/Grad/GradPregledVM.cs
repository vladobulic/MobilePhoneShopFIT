using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class GradPregledVM
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public int PostanskiBroj { get; set; }

        public int ZupanijaId { get; set; }

        public string zupanijaNaziv { get; set; }


        public static GradPregledVM convertToGradDodajViewModel(Grad x)
        {

            return new GradPregledVM
            {
                Id = x.Id,
                Naziv = x.Naziv,
                PostanskiBroj = x.PostanskiBroj,
                ZupanijaId = x.ZupanijaId,
                zupanijaNaziv = x.Zupanija.Naziv
            };
        }

    }
}
