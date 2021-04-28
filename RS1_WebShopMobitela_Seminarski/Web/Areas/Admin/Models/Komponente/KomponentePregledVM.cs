using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class KomponentePregledVM
    {
		public int Id { get; set; }

		public string Ime { get; set; }

		public int KolicinaNaSkladistu { get; set; }

		public double PreporucenaCijena { get; set; }

		

		public int TipKomponenteId { get; set; }
		public string TipKomponente { get; set; }
		public List<SelectListItem> tipovikomponente { get; set; }


		public int DobavljacID { get; set; }
		public string dobavljac { get; set; }
		public List<SelectListItem> dobavljaci { get; set; }

		public static KomponentePregledVM ConvertToKomponenteViewModel(Komponente x)
        {
			return new KomponentePregledVM
			{
				Id = x.Id,
				Ime = x.Ime,
				KolicinaNaSkladistu = x.KolicinaNaSkladistu,
				PreporucenaCijena = x.PreporucenaCijena,
				TipKomponenteId = x.TipKomponenteId,
				TipKomponente = x.TipKomponente.Naziv,
				DobavljacID = x.DobavljacID,
				dobavljac = x.Dobavljac.Ime
			};
        }

	}
}
