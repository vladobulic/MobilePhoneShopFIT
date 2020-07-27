using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Helpers
{
    public static class ListConverter
    {
        public static List<SelectListItem> ConvertToSelectListItem(IEnumerable<Proizvodjac> lista)
        {
            return lista.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Naziv
            }).ToList();
        }
    }
}
