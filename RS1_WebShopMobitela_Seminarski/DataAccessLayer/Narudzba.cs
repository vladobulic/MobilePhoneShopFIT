using DataAccessLayer;
using System;
public class Narudzba : BaseEntity
{

    public double UkupnaCijena { get; set; }
    public string Ulica { get; set; }
    public DateTime Datum { get; set; }
    public int Stanje { get; set; }

    public virtual System.Collections.Generic.List<StavkaNarudzbe> StavkaNarudzbe { get; set; }

    public int KupacId { get; set; }
    public virtual Kupac Kupac { get; set; }

    public int GradId { get; set; }
    public virtual Grad Grad { get; set; }

    public int? ZaposlenikId { get; set; }
    public virtual Zaposlenik Zaposlenik { get; set; }

}
