using DataAccessLayer;
using System;
public class Mobiteli : BaseEntity{
	 
	public string Naziv;
	public float Megapikseli;
	public float Ram_Gb;
	public int StanjeNaSkladistu;
	public bool EksternaMemorija;
	public double Cijena;
	public int KapacitetBaterije;
	public int Tezina;
	public string Rezolucija;
	public float DijagonalaEkrana;
	public string Procesor;
	public string Graficka;
	public bool IsDeleted;


	public virtual System.Collections.Generic.List<Slika> Slika { get; set; }
	public virtual System.Collections.Generic.List<StavkaNarudzbe> StavkaNarudzbe { get; set; }
	public virtual System.Collections.Generic.List<Komentar> Komentar { get; set; }

	public int ProizvodjacId { get; set; }
	public virtual Proizvodjac Prozivodjac { get; set; }
	public int OperativniSustavId { get; set; }
	public virtual OperativniSustav OperativniSustav { get; set; }
	public int PopustId { get; set; }
	public virtual Popusti Popust { get; set; }

}
