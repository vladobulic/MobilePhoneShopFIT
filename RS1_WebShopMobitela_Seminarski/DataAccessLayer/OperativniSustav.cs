using DataAccessLayer;
using System;
public class OperativniSustav : BaseEntity{
	 
	public string Naziv;
	public float Verzija;

	public virtual System.Collections.Generic.List<Mobiteli> Mobiteli { get; set; }

}
