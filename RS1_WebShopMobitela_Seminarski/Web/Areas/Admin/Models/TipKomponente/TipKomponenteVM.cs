using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class TipKomponenteVM
    {
		public int Id { get; set; }

		public string Naziv { get; set; }

	
		public static TipKomponenteVM ConvertToTipKomponenteViewModel(TipKomponente x)
        {
			return new TipKomponenteVM
			{
				Id = x.Id,
				Naziv = x.Naziv
				
			};
        }

	}
}
