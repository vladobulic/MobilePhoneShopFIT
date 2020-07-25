using DataAccessLayer;
using System;
public class Popusti : BaseEntity{
	 
	public DateTime DatumOd;
	public DateTime DatumDo;
	public float PostotakPopusta;

	public System.Collections.Generic.List<Mobiteli> Mobiteli;

}
