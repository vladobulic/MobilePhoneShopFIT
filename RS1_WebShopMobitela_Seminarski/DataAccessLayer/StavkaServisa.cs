using DataAccessLayer;
using System;
public class StavkaServisa : BaseEntity{
	 
	public double Cijena { get; set; }
	public string Ime { get; set; }

	public int ServisId { get; set; }
	public virtual Servis Servis { get; set; }

	public int KomponenteId { get; set; }
	public virtual Komponente Komponente { get; set; }

}
