using DataAccessLayer;
using System;
public class Administrator : BaseEntity {

	public string Email { get; set; }
	public bool IsSuperAdmin { get; set; }
	public string Ime { get; set; }
	public string Prezime { get; set; }

	public virtual System.Collections.Generic.List<Poruka> Poruka { get; set; }

	public virtual ApplicationUser ApplicationUser { get; set; }



}
