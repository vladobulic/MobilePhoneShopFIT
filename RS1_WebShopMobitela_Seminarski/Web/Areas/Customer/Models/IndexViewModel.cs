using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Models
{
    public class IndexViewModel
    {
        public int PriceTo { get; set; }

        
        public List<MobitelViewModel> Mobiteli{ get;set; }

        public int ProizvodjacId { get; set; }
        public List<SelectListItem> Proizvodjaci { get; set; }

        int ? Page { get; set; }
    }
}
