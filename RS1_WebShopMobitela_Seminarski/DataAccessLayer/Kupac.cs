using DataAccessLayer;
using System;
public class Kupac : BaseEntity {

	public string Ime { get; set; }
	public string Prezime { get; set; }
	public string Email { get; set; }
	public int BrojPokusaja { get; set; }
	public DateTime DatumPokusaja { get; set; }
	public string BrojMobitela { get; set; }

	public virtual System.Collections.Generic.List<Narudzba> Narudzba { get; set; }
	public virtual System.Collections.Generic.List<Komentar> Komentar { get; set; }


	public int GradId { get; set; }
	public virtual Grad Grad {get;set;}

	public int? BannedKupacId { get; set; }
	public virtual BannedKupac BannedKupac { get; set; }

	public virtual ApplicationUser ApplicationUser { get; set; }

}
