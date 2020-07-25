using DataAccessLayer;
using System;
public class StavkaServisa : BaseEntity{
	 
	public double Cijena;
	public string Ime;

	public int ServisId { get; set; }
	public virtual Servis Servis { get; set; }

	public int KomponenteId { get; set; }
	public virtual Komponente Komponente { get; set; }

}
