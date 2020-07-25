using DataAccessLayer;
using System;
public class BannedKupac : BaseEntity {
	 
	public DateTime DatumDo;
	public Boolean Zauvijek;
	public string Razlog;

	public virtual System.Collections.Generic.List<Kupac> Kupac { get; set; }

}
