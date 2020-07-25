using DataAccessLayer;
using System;
public class Komentar : BaseEntity{
	 
	public string Sadrzaj;
	public DateTime Datum;
	public bool IsDeleted;

	public int MobitelId { get; set; }
	public virtual Mobiteli Mobitel { get; set; }

	public int KupacId { get; set; }
	public virtual Kupac Kupac { get; set; }

}
