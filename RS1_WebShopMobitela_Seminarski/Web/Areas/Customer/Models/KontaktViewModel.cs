using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Models
{
    public class KontaktViewModel
    {
        [Required(ErrorMessage = "Morate unjeti ime")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Morate unjeti mail")]
        [EmailAddress(ErrorMessage = "Mail nije validan")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Morate unjeti poruku")]
        [MinLength(20,ErrorMessage = "Poruka mora imati bar 20 znakova")]
        public string Poruka { get; set; }
    }
}
