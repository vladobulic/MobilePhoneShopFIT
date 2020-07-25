using DataAccessLayer;
using System;
public class Poruka : BaseEntity{
	 
	public string Subjekt;
	public string Sadrzaj;
	public DateTime DatumSlanja;
	public Boolean Procitano;
	public Boolean Hitno;

	public int ZaposlenikId { get; set; }
	public virtual Zaposlenik Zaposlenik { get; set; }

	public int AdministratorId { get; set; }
	public virtual Administrator Administrator { get; set; }

}
