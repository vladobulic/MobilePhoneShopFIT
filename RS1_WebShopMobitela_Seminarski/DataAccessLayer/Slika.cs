using DataAccessLayer;
using System;
public class Slika : BaseEntity{
	 
	public string Path { get; set; }
	public int Order { get; set; }


	public int MobitelId { get; set; }
	public virtual Mobiteli Mobitel { get; set; }

}
