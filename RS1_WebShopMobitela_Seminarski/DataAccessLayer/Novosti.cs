using DataAccessLayer;
using System;
public class Novosti : BaseEntity{
	 
	public string SadrzajTekst;
	public string Naslov;
	public DateTime Datum;

	// koji zaposlenik je objavio novost
	public int ZaposlenikId { get; set; }
	public virtual Zaposlenik Zaposlenik { get; set; }

}
