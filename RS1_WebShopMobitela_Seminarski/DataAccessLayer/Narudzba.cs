using DataAccessLayer;
using System;
public class Narudzba : BaseEntity
{

    public double UkupnaCijena { get; set; }
    
    public DateTime Datum { get; set; }


    // 1 = Obrada, 2 = Posiljka poslana
    public int Stanje { get; set; }

    public string KontaktTelefon {get;set; }
    public virtual System.Collections.Generic.List<StavkaNarudzbe> StavkaNarudzbe { get; set; }


    // koji je kupac narucio ako je kupac bio logiran
    public int KupacId { get; set; }
    public virtual Kupac Kupac { get; set; }

    public string Opcina { get; set; }
    public string Kanton { get; set; }
    public string PostanskiBroj { get; set; }
    public string Ulica { get; set; }



    public int? ZaposlenikId { get; set; }
    public virtual Zaposlenik Zaposlenik { get; set; }

}
