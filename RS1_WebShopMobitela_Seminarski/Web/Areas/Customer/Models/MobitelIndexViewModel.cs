using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Models
{
    public class MobitelIndexViewModel
    {
        public MobitelViewModel Mobitel { get; set; }

        public List<Komentar> Komentari { get;set; }
    }
}
