using DataAccessLayer;
using System;
public class Poruka : BaseEntity{
	 
	public string Subjekt { get; set; }
	public string Sadrzaj { get; set; }
	public DateTime DatumSlanja { get; set; }
	public Boolean Procitano { get; set; }
	public Boolean Hitno { get; set; }

	public int ZaposlenikId { get; set; }
	public virtual Zaposlenik Zaposlenik { get; set; }

	public int AdministratorId { get; set; }
	public virtual Administrator Administrator { get; set; }

}
