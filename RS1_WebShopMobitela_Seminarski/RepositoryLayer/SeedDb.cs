using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public static class SeedDb
    {
        public static void Make(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().HasData(new Administrator { Id = 1, Email = "admin@admin.com", Ime = "admin", IsSuperAdmin = true, Password = "admin", Prezime = "admin" });

            modelBuilder.Entity<Dobavljac>().HasData(new Dobavljac { Id = 1, Ime = "Samsung", Broj = "063323718", Mail = "dobavljac@dobavljac.com" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { Id = 1, Naziv = "Hercegovacko-Neretvanska" }, new Zupanija { Id = 2, Naziv = "Zapadno-Hercegovacka" });
            modelBuilder.Entity<Grad>().HasData(new Grad { Id = 1, ZupanijaId = 1, Naziv = "Citluk", PostanskiBroj = 88260 }, new Grad { Id = 2, ZupanijaId = 2, Naziv = "Siroki Brijeg", PostanskiBroj = 88520 });

            modelBuilder.Entity<Proizvodjac>().HasData(new Proizvodjac { Id = 1, Naziv = "Samsung" });
            modelBuilder.Entity<OperativniSustav>().HasData(new OperativniSustav { Id = 1, Verzija = 11f, Naziv = "Android" });

            modelBuilder.Entity<Popusti>().HasData(new Popusti { DatumOd = DateTime.Now, DatumDo = DateTime.Now, Id = 1, PostotakPopusta = 5f });

            modelBuilder.Entity<Mobiteli>().HasData(new Mobiteli
            {
                Naziv = "S10",
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 1200f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                ProizvodjacId = 1,
                Id = 1,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "S20",
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 1200f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                ProizvodjacId = 1,
                Id = 2,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "A50",
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 1200f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                ProizvodjacId = 1,
                Id = 3,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }
            );
            modelBuilder.Entity<Komentar>().HasData(new Komentar { Id = 1, Datum = DateTime.Now, IsDeleted = false, KupacId = 1, MobitelId = 1 });



            modelBuilder.Entity<Kupac>().HasData(new Kupac { Id = 1, Email = "kupac@kupac.com", BrojMobitela = "063525555", Ime = "kupac", Prezime = "kupic", BrojPokusaja = 0, DatumPokusaja = DateTime.Now, GradId = 1, Password = "kupac" });
            //modelBuilder.Entity<Komponente>().HasData();
            //modelBuilder.Entity<Narudzba>().HasData();
            modelBuilder.Entity<Zaposlenik>().HasData(new Zaposlenik { Id = 1, isDeleted = false, Ime = "Zaposlenik", Prezime = "Zaposlenko", Email = "Zaposlenik@zaposlenik.com", Gradid = 1, Password = "zaposlenik", Ulica = "markovac" });
            modelBuilder.Entity<Novosti>().HasData(new Novosti { Id = 1, Datum = DateTime.Now, Naslov = "Novi iPhone stigao u BiH", SadrzajTekst = "ok mobitel", ZaposlenikId = 1 });


            //modelBuilder.Entity<Poruka>().HasData();

            //modelBuilder.Entity<Servis>().HasData();
            //modelBuilder.Entity<Slika>().HasData();
            //modelBuilder.Entity<SmsLog>().HasData();
            //modelBuilder.Entity<StavkaNarudzbe>().HasData();
            //modelBuilder.Entity<StavkaServisa>().HasData();
            //modelBuilder.Entity<TipKomponente>().HasData();

            //modelBuilder.Entity<BannedKupac>().HasData();
            //modelBuilder.Entity<Log>().HasData();
        }
    }
}
