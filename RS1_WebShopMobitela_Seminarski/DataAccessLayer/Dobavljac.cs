using DataAccessLayer;
using System;
public class Dobavljac : BaseEntity{
	 
	public string Ime;
	public string Broj;
	public string Mail;

	public virtual System.Collections.Generic.List<Komponente> Komponente { get; set; }

}
