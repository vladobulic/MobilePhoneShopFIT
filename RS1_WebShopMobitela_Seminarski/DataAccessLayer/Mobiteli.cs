using DataAccessLayer;
using System;
using System.ComponentModel.DataAnnotations;

public class Mobiteli : BaseEntity{
	 
	public string Naziv { get; set; }

	public string Opis { get; set; }
	public string KratkiOpis { get; set; }
	public float Megapikseli { get; set; }
	public float Ram_Gb { get; set; }
	public int StanjeNaSkladistu { get; set; }
	public bool EksternaMemorija { get; set; }
	public double Cijena { get; set; }
	public int KapacitetBaterije { get; set; }
	public int Tezina { get; set; }
	public string Rezolucija { get; set; }
	public float DijagonalaEkrana { get; set; }
	public string Procesor { get; set; }
	public string Graficka { get; set; }
	public bool IsDeleted { get; set; }


	public virtual System.Collections.Generic.List<Slika> Slika { get; set; }
	public virtual System.Collections.Generic.List<StavkaNarudzbe> StavkaNarudzbe { get; set; }
	public virtual System.Collections.Generic.List<Komentar> Komentar { get; set; }

	public int? ProizvodjacId { get; set; }
	public virtual Proizvodjac Prozivodjac { get; set; }
	public int? OperativniSustavId { get; set; }
	public virtual OperativniSustav OperativniSustav { get; set; }
	public int? PopustId { get; set; }
	public virtual Popusti Popust { get; set; }

}
