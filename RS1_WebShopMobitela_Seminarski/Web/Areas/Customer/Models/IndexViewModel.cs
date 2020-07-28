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

        public string my_range { get; set; }
        
        public List<MobitelViewModel> Mobiteli{ get;set; }

        public int ProizvodjacId { get; set; }
        public List<SelectListItem> Proizvodjaci { get; set; }

        public int ? Page { get; set; }

        public bool PriceDesc { get; set; }

        public string SearchName { get; set; }


        public int sliderFrom { get; set; }
        public int sliderTo { get; set; }


        // paging helper attributes
        public int TotalPages { get; set; }

    }
}
