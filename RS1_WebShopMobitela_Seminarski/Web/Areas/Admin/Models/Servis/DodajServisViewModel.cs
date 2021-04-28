using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Admin.Models
{
	public class DodajServisViewModel
	{

		public int Id { get; set; }

		[Required]
		public DateTime DatumPrijema { get; set; }
		[Required]
		public DateTime DatumZavrsetka { get; set; }
		public string Opis { get; set; }
		[Required]
		public double CijenaUkupno { get; set; }

		public List<SelectListItem> zaposlenici { get; set; }

		[Required]
		public int ZaposlenikId { get; set; }
		public string ImeZaposlenika { get; set; }
		public int stanjeServisa { get; set; }

		//[Required(ErrorMessage = "To Number Required", AllowEmptyStrings = false)]
		//[Phone]
		//[Display(Name = "To Number")]
		//public string To { get; set; }

		//[Required(ErrorMessage = "From Number Required", AllowEmptyStrings = false)]
		//[Phone]
		//[Display(Name = "From Number")]
		//public string From { get; set; }

		//[Required(ErrorMessage = "Message Text Required", AllowEmptyStrings = false)]
		//[Display(Name = "Message Text")]
		//public string Text { get; set; }

		public static DodajServisViewModel ConvertToServisViewModel(Servis x)
        {
           

            // cijena je sa popustom ako je popust true. 
            return new DodajServisViewModel
            {
				Id = x.Id,
               DatumPrijema = x.DatumPrijema,
			   DatumZavrsetka = x.DatumZavrsetka,
			   //CijenaUkupno = x.StavkaServisa.Select(y=>y.Cijena).Where(x.Id = y.sa),
			   Opis = x.Opis,
			   ZaposlenikId = x.ZaposlenikId,
			   stanjeServisa = x.StanjeServisa,
			   ImeZaposlenika = x.Zaposlenik.Ime
            };
        }

    }
}
