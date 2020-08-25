using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class StavkeNarudzbeVM
    {
		public int Id { get; set; }

		public int Kolicina { get; set; }

		public double Cijena { get; set; }

		public int MobitelId { get; set; }

		public string mobitel { get; set; }

		public int NarudzbaId { get; set; }
		

		public static StavkeNarudzbeVM ConvertToStavkeNarudzbeViewModel(StavkaNarudzbe x)
        {
			return new StavkeNarudzbeVM
			{
				Id = x.Id,
				Kolicina = x.Kolicina,
				Cijena = x.Cijena,
				MobitelId = x.MobitelId,
				mobitel = x.Mobitel.Naziv,
				NarudzbaId = x.NarudzbaId
			};
        }


        public static List<StavkeNarudzbeVM> ConvertToStavkeNarudzbeViewModel(IEnumerable<StavkaNarudzbe> stavkaNarudzbe)
        {
            // cijena je sa popustom ako je popust true. 
            return stavkaNarudzbe.Select(x =>
                new StavkeNarudzbeVM
                {
                    Id = x.Id,
					Kolicina = x.Kolicina,
					Cijena = x.Cijena,
					MobitelId = x.MobitelId,
					mobitel = x.Mobitel.Naziv,
					NarudzbaId = x.NarudzbaId
				}
            ).ToList();
        }
    }
}
