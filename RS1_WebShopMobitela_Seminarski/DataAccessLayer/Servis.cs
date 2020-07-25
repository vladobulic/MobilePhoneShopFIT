using DataAccessLayer;
using System;
public class Servis : BaseEntity{
	 
	public DateTime DatumPrijema;
	public DateTime DatumZavrsetka;
	public string Opis;
	public double CijenaUkupno;
	public int StanjeServisa;

	public virtual System.Collections.Generic.List<StavkaServisa> StavkaServisa { get; set; }

	public int ZaposlenikId { get; set; }
	public virtual Zaposlenik Zaposlenik { get; set; }

}
