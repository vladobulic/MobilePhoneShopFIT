using DataAccessLayer;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceLayer;
using ServiceLayer.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Web.Areas.Identity.Models.AccountViewModels
{
    public class RegisterViewModel
    {


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }

        [Required]
        public string BrojMobitela { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Izaberite vas grad molimo vas")]
        public int GradId { get; set; }

        public List<SelectListItem> Gradovi { get; set; }



        public Kupac convertToKupac(ApplicationUser user)
        {
           return new Kupac
            {
                Email = Email,
                Ime = Ime,
                Prezime = Prezime,
                GradId = GradId,
                ApplicationUser = user
            };
        }
    }
}
