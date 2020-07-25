using DataAccessLayer;
using System;
public class TipKomponente : BaseEntity{
	 
	public string naziv;

	public virtual System.Collections.Generic.List<Komponente> Komponente { get; set; }

}
