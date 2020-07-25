using DataAccessLayer;
using System;
public class Zupanija : BaseEntity{
	 
	public string Naziv;

	public virtual System.Collections.Generic.List<Grad> Grad { get; set; }

}
