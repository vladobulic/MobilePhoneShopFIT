using DataAccessLayer;
using System;
public class Kupac : BaseEntity {

	public string Ime;
	public string Prezime;
	public string Email;
	public string Password;
	public int BrojPokusaja;
	public DateTime DatumPokusaja;
	public string BrojMobitela;

	public virtual System.Collections.Generic.List<Narudzba> Narudzba { get; set; }
	public virtual System.Collections.Generic.List<Komentar> Komentar { get; set; }


	public int GradId { get; set; }
	public virtual Grad Grad {get;set;}

	public int? BannedKupacId { get; set; }
	public virtual BannedKupac BannedKupac { get; set; }

}
