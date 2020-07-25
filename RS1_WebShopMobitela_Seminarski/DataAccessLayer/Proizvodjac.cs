using DataAccessLayer;
using System;
public class Proizvodjac : BaseEntity{
	 
	public string Naziv { get; set; }
	public float Verzija { get; set; }

	public virtual System.Collections.Generic.List<Mobiteli> Mobiteli { get; set; }

}
