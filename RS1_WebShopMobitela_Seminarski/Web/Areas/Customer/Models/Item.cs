using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Areas.Customer.Models
{
    public class Item
    {
        public ProductModel Product { get; set; }

        public int Quantity { get; set; }
    }
}
