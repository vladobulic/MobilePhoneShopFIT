using DataAccessLayer;
using System;
public class OperativniSustav : BaseEntity{
	 
	public string Naziv { get; set; }
	public float Verzija { get; set; }

	public virtual System.Collections.Generic.List<Mobiteli> Mobiteli { get; set; }

}
