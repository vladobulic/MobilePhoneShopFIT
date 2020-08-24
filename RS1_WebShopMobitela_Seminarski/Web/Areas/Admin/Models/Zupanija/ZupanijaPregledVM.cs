using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class ZupanijaPregledVM
    {
        public int Id { get; set; }

        public string Naziv { get; set; }


       public static ZupanijaPregledVM ConvertToZupanijaViewModel (Zupanija x)
        {
            return new ZupanijaPregledVM
            {
                Id = x.Id,
                Naziv = x.Naziv
            };
        }
    }
}
