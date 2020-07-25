using DataAccessLayer;
using System;
public class TipKomponente : BaseEntity{
	 
	public string Naziv { get; set; }

	public virtual System.Collections.Generic.List<Komponente> Komponente { get; set; }

}
