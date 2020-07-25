using DataAccessLayer;
using System;
public class Administrator : BaseEntity {

	public string Email;
	public string Password;
	public bool IsSuperAdmin;
	public string Ime;
	public string Prezime;

	public virtual System.Collections.Generic.List<Poruka> Poruka { get; set; }

}
