using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Models.ManageViewModels
{
    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessage = "Morate unjeti kontakt telefon")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(06)\d\s*\d{3}\s*\d{3}", ErrorMessage = "Format vaseg broja nije dobar, probajte sa 06X XXX XXX")]
        public string PhoneNumber { get; set; }
        public string FullPhone { get; set; }
    }
}
