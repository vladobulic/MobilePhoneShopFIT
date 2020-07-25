using DataAccessLayer;
using System;
public class Komentar : BaseEntity{
	 
	public string Sadrzaj { get; set; }
	public DateTime Datum { get; set; }
	public bool IsDeleted { get; set; }

	public int MobitelId { get; set; }
	public virtual Mobiteli Mobitel { get; set; }

	public int KupacId { get; set; }
	public virtual Kupac Kupac { get; set; }

}
