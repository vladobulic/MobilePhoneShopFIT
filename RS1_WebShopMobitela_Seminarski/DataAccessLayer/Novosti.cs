using DataAccessLayer;
using System;
public class Novosti : BaseEntity{
	 
	public string SadrzajTekst { get; set; }
	public string Naslov { get; set; }
	public DateTime Datum { get; set; }

	// koji zaposlenik je objavio novost
	public int ZaposlenikId { get; set; }
	public virtual Zaposlenik Zaposlenik { get; set; }

}
