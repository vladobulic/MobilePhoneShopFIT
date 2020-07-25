using DataAccessLayer;
using System;
public class Servis : BaseEntity{
	 
	public DateTime DatumPrijema { get; set; }
	public DateTime DatumZavrsetka { get; set; }
	public string Opis { get; set; }
	public double CijenaUkupno { get; set; }
	public int StanjeServisa { get; set; }

	public virtual System.Collections.Generic.List<StavkaServisa> StavkaServisa { get; set; }

	public int ZaposlenikId { get; set; }
	public virtual Zaposlenik Zaposlenik { get; set; }

}
