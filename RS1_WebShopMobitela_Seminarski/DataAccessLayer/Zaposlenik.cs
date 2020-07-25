using DataAccessLayer;
using System;
public class Zaposlenik : BaseEntity {
	 
	public string Ime;
	public string Prezime;
	public string Ulica;
	public string Email;
	public string Password;
	public bool isDeleted;

	public virtual System.Collections.Generic.List<Servis> Servis { get; set; }
	public virtual System.Collections.Generic.List<Narudzba> Narudzba { get; set; }
	public virtual System.Collections.Generic.List<Novosti> Novosti { get; set; }
	public virtual System.Collections.Generic.List<Poruka> Poruka { get; set; }

	public int Gradid { get; set; }
	public virtual Grad Grad { get; set; }

}
