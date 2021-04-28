using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class SviAdmini
    {
        public int Id { get; set; }
        public string ime { get; set; }

        public static SviAdmini ConvertTo(Administrator x)
        {
            return new SviAdmini
            {
                Id = x.Id,
                ime = x.Ime
            };
        }
    }
}
