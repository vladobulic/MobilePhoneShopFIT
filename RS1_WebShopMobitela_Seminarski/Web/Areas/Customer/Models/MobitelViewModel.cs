using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Models
{
    public class MobitelViewModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public static List<MobitelViewModel> ConvertToMobitelViewModel(IEnumerable<Mobiteli> mobiteli)
        {
            return mobiteli.Select(x =>
                new MobitelViewModel { Id = x.Id, Naziv = x.Naziv }
            ).ToList();
        }
    }

    
}
