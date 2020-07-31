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
            modelBuilder.Entity<Administrator>().HasData(new Administrator { Id = 1, Email = "admin@admin.com", Ime = "admin", IsSuperAdmin = true, Prezime = "admin" });

            modelBuilder.Entity<Dobavljac>().HasData(new Dobavljac { Id = 1, Ime = "Samsung", Broj = "063323718", Mail = "dobavljac@dobavljac.com" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { Id = 1, Naziv = "Hercegovacko-Neretvanska" }, new Zupanija { Id = 2, Naziv = "Zapadno-Hercegovacka" });
            modelBuilder.Entity<Grad>().HasData(new Grad { Id = 1, ZupanijaId = 1, Naziv = "Citluk", PostanskiBroj = 88260 }, new Grad { Id = 2, ZupanijaId = 2, Naziv = "Siroki Brijeg", PostanskiBroj = 88520 });

            modelBuilder.Entity<Proizvodjac>().HasData(new Proizvodjac { Id = 1, Naziv = "Samsung" }, new Proizvodjac { Id = 2, Naziv = "Apple" }, new Proizvodjac { Id = 3, Naziv = "Huawei" }
            , new Proizvodjac { Id = 4, Naziv = "Xiaomi" }, new Proizvodjac { Id = 5, Naziv = "Nokia" }, new Proizvodjac { Id = 6, Naziv = "Google" }, new Proizvodjac { Id = 7, Naziv = "CAT" }, new Proizvodjac { Id = 8, Naziv = "YEZZ" });
            modelBuilder.Entity<OperativniSustav>().HasData(new OperativniSustav { Id = 1, Verzija = 11f, Naziv = "Android" }, new OperativniSustav { Id = 2, Verzija = 13.4f, Naziv = "iOS" });

            modelBuilder.Entity<Popusti>().HasData(new Popusti { DatumOd = DateTime.Now, DatumDo = DateTime.Now, Id = 1, PostotakPopusta = 0.10f });

            modelBuilder.Entity<Mobiteli>().HasData(new Mobiteli
            {
                Naziv = "S10",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 1210f,
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
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 1580f,
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
                Naziv = "S10 Lite",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                ProizvodjacId = 1,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 990f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                
                Id = 3,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "Redmi Note 9",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                ProizvodjacId = 4,
                Cijena = 440f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Id = 4,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "Pixel 4",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 5,
                ProizvodjacId = 6,
                Cijena = 1320f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "iPhone 11 pro",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 6,
                ProizvodjacId = 2,
                Cijena = 2350f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 2,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }
            , new Mobiteli
            {
                Naziv = "iPhone XR",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 7,
                ProizvodjacId = 2,
                Cijena = 1220f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 2,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "iPhone 8",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 8,
                ProizvodjacId = 2,
                Cijena = 880f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 2,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "Honor 9",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 9,
                ProizvodjacId = 3,
                Cijena = 390f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "Mate 30 Pro",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 10,
                ProizvodjacId = 3,
                Cijena = 990f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "B26",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 11,
                ProizvodjacId = 7,
                Cijena = 250f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "Classic c221",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 12,
                ProizvodjacId = 8,
                Cijena = 30f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "42",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 13,
                ProizvodjacId = 5,
                Cijena = 430f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "210",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                Id = 14,
                ProizvodjacId = 5,
                Cijena = 430f,
                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = null,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }, new Mobiteli
            {
                Naziv = "A71",
                Opis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.",
                KratkiOpis = "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća",

                IsDeleted = false,
                KapacitetBaterije = 3200,
                Megapikseli = 12.3f,
                Cijena = 670f,
                DijagonalaEkrana = 6.1f,
                OperativniSustavId = 1,
                Procesor = "Xenon A5G",
                Ram_Gb = 8f,
                ProizvodjacId = 1,
                Id = 15,
                Rezolucija = "FULL HD IPS",
                Tezina = 320,
                EksternaMemorija = true,
                PopustId = 1,
                Graficka = "Ardent",
                StanjeNaSkladistu = 10
            }

            ); ;
            modelBuilder.Entity<Komentar>().HasData(new Komentar { Id = 1, Datum = DateTime.Now, IsDeleted = false, KupacId = 1, MobitelId = 1 });
            modelBuilder.Entity<Slika>().HasData(
                new Slika { 
                    Id = 1,
                    MobitelId = 1,
                    Order = 1,
                    Path = "/Customer/slike/samsung.jpg"
                }, new Slika
                {
                    Id = 2,
                    MobitelId = 2,
                    Order = 1,
                    Path = "/Customer/slike/samsungS20.jpg"
                }, new Slika
                {
                    Id = 3,
                    MobitelId = 3,
                    Order = 1,
                    Path = "/Customer/slike/samsung_galaxy_a30.jpg"
                }
                , new Slika
                {
                    Id = 4,
                    MobitelId = 4,
                    Order = 1,
                    Path = "/Customer/slike/redminote.jpg"
                }
                , new Slika
                {
                    Id = 5,
                    MobitelId = 5,
                    Order = 1,
                    Path = "/Customer/slike/pixel4-2.jpg"
                }, new Slika
                {
                    Id = 6,
                    MobitelId = 6,
                    Order = 1,
                    Path = "/Customer/slike/appiph11.jpg"
                }, new Slika
                {
                    Id = 7,
                    MobitelId = 7,
                    Order = 1,
                    Path = "/Customer/slike/apple_iphone_xr.jpg"
                }, new Slika
                {
                    Id = 8,
                    MobitelId = 8,
                    Order = 1,
                    Path = "/Customer/slike/iphone_8.jpg"
                }, new Slika
                {
                    Id = 9,
                    MobitelId = 9,
                    Order = 1,
                    Path = "/Customer/slike/huawei_honor_9.jpg"
                }, new Slika
                {
                    Id = 10,
                    MobitelId = 10,
                    Order = 1,
                    Path = "/Customer/slike/mate30pro.jpg"
                }, new Slika
                {
                    Id = 11,
                    MobitelId = 11,
                    Order = 1,
                    Path = "/Customer/slike/catb26.jpg"
                }, new Slika
                {
                    Id = 12,
                    MobitelId = 12,
                    Order = 1,
                    Path = "/Customer/slike/yezz_classic_c221.jpg"
                }, new Slika
                {
                    Id = 13,
                    MobitelId = 13,
                    Order = 1,
                    Path = "/Customer/slike/nokia42.jpg"
                }
                , new Slika
                {
                    Id = 14,
                    MobitelId = 14,
                    Order = 1,
                    Path = "/Customer/slike/nokia42.jpg"
                }, new Slika
                {
                    Id = 15,
                    MobitelId = 15,
                    Order = 1,
                    Path = "/Customer/slike/nokia_210.png"
                }
                );


            modelBuilder.Entity<Kupac>().HasData(new Kupac { Id = 1, Email = "kupac@kupac.com", BrojMobitela = "063525555", Ime = "kupac", Prezime = "kupic", BrojPokusaja = 0, DatumPokusaja = DateTime.Now, GradId = 1 });
            //modelBuilder.Entity<Komponente>().HasData();
            //modelBuilder.Entity<Narudzba>().HasData();
            modelBuilder.Entity<Zaposlenik>().HasData(new Zaposlenik { Id = 1, isDeleted = false, Ime = "Zaposlenik", Prezime = "Zaposlenko", Email = "Zaposlenik@zaposlenik.com", Gradid = 1,  Ulica = "markovac" });
            modelBuilder.Entity<Novosti>().HasData(new Novosti { Id = 1, Datum = DateTime.Now, Naslov = "Novi iPhone stigao u BiH", SadrzajTekst = "ok mobitel", ZaposlenikId = 1 });


            //modelBuilder.Entity<Poruka>().HasData();

            //modelBuilder.Entity<Servis>().HasData();
            
            //modelBuilder.Entity<SmsLog>().HasData();
            //modelBuilder.Entity<StavkaNarudzbe>().HasData();
            //modelBuilder.Entity<StavkaServisa>().HasData();
            //modelBuilder.Entity<TipKomponente>().HasData();

            //modelBuilder.Entity<BannedKupac>().HasData();
            //modelBuilder.Entity<Log>().HasData();
        }
    }
}
