using DataAccessLayer;
using System;
public class Komponente : BaseEntity{
	 
	public string Ime;
	public int KolicinaNaSkladistu;
	public double PreporucenaCijena;

	public virtual System.Collections.Generic.List<StavkaServisa> StavkaServisa { get; set; }

	public int TipKomponenteId { get; set; }
	public virtual TipKomponente TipKomponente { get; set; }


	public int DobavljacID { get; set; }
	public virtual Dobavljac Dobavljac { get; set; }

}
