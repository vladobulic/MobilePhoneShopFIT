using DataAccessLayer;
using System;
public class BannedKupac : BaseEntity {
	 
	public DateTime DatumDo { get; set; }
	public Boolean Zauvijek { get; set; }
	public string Razlog { get; set; }

	public virtual System.Collections.Generic.List<Kupac> Kupac { get; set; }

}
