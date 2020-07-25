using DataAccessLayer;
using System;
public class Dobavljac : BaseEntity{
	 
	public string Ime { get; set; }
	public string Broj { get; set; }
	public string Mail { get; set; }

	public virtual System.Collections.Generic.List<Komponente> Komponente { get; set; }

}
