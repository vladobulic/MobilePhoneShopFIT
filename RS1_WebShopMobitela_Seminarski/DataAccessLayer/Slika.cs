using DataAccessLayer;
using System;
public class Slika : BaseEntity{
	 
	public string Path;
	public int Order;


	public virtual System.Collections.Generic.List<Mobiteli> Mobitel { get; set; }

}
