﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSuperAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administratori");
                });

            modelBuilder.Entity("BannedKupac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumDo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Razlog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Zauvijek")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BannedKupci");
                });

            modelBuilder.Entity("Dobavljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Broj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dobavljaci");
                });

            modelBuilder.Entity("Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.Property<int>("ZupanijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZupanijaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("MobitelId")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("MobitelId");

                    b.ToTable("Komentari");
                });

            modelBuilder.Entity("Komponente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DobavljacID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KolicinaNaSkladistu")
                        .HasColumnType("int");

                    b.Property<double>("PreporucenaCijena")
                        .HasColumnType("float");

                    b.Property<int>("TipKomponenteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DobavljacID");

                    b.HasIndex("TipKomponenteId");

                    b.ToTable("Komponente");
                });

            modelBuilder.Entity("Kupac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BannedKupacId")
                        .HasColumnType("int");

                    b.Property<string>("BrojMobitela")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrojPokusaja")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPokusaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BannedKupacId");

                    b.HasIndex("GradId");

                    b.ToTable("Kupci");
                });

            modelBuilder.Entity("Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionDescriptor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("Mobiteli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<float>("DijagonalaEkrana")
                        .HasColumnType("real");

                    b.Property<bool>("EksternaMemorija")
                        .HasColumnType("bit");

                    b.Property<string>("Graficka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KapacitetBaterije")
                        .HasColumnType("int");

                    b.Property<float>("Megapikseli")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperativniSustavId")
                        .HasColumnType("int");

                    b.Property<int>("PopustId")
                        .HasColumnType("int");

                    b.Property<string>("Procesor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProizvodjacId")
                        .HasColumnType("int");

                    b.Property<float>("Ram_Gb")
                        .HasColumnType("real");

                    b.Property<string>("Rezolucija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StanjeNaSkladistu")
                        .HasColumnType("int");

                    b.Property<int>("Tezina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperativniSustavId");

                    b.HasIndex("PopustId");

                    b.HasIndex("ProizvodjacId");

                    b.ToTable("Mobiteli");
                });

            modelBuilder.Entity("Narudzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("Stanje")
                        .HasColumnType("int");

                    b.Property<double>("UkupnaCijena")
                        .HasColumnType("float");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZaposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.HasIndex("KupacId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Narudzbe");
                });

            modelBuilder.Entity("Novosti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SadrzajTekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZaposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Novosti");
                });

            modelBuilder.Entity("OperativniSustav", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Verzija")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("OperativniSustavi");
                });

            modelBuilder.Entity("Popusti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumDo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumOd")
                        .HasColumnType("datetime2");

                    b.Property<float>("PostotakPopusta")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Popusti");
                });

            modelBuilder.Entity("Poruka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumSlanja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Hitno")
                        .HasColumnType("bit");

                    b.Property<bool>("Procitano")
                        .HasColumnType("bit");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subjekt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZaposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("Proizvodjac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Verzija")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Proizvodjaci");
                });

            modelBuilder.Entity("Servis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CijenaUkupno")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumPrijema")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StanjeServisa")
                        .HasColumnType("int");

                    b.Property<int>("ZaposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Servisi");
                });

            modelBuilder.Entity("Slika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MobitelId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MobitelId");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("SmsLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Broj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dodatnisadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SmsLog");
                });

            modelBuilder.Entity("StavkaNarudzbe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("MobitelId")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MobitelId");

                    b.HasIndex("NarudzbaId");

                    b.ToTable("StavkeNarudzbe");
                });

            modelBuilder.Entity("StavkaServisa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KomponenteId")
                        .HasColumnType("int");

                    b.Property<int>("ServisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KomponenteId");

                    b.HasIndex("ServisId");

                    b.ToTable("StavkaServisa");
                });

            modelBuilder.Entity("TipKomponente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipKomponente");
                });

            modelBuilder.Entity("Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gradid")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Gradid");

                    b.ToTable("Zaposlenici");
                });

            modelBuilder.Entity("Zupanija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zupanije");
                });

            modelBuilder.Entity("Grad", b =>
                {
                    b.HasOne("Zupanija", "Zupanija")
                        .WithMany("Grad")
                        .HasForeignKey("ZupanijaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Komentar", b =>
                {
                    b.HasOne("Kupac", "Kupac")
                        .WithMany("Komentar")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mobiteli", "Mobitel")
                        .WithMany("Komentar")
                        .HasForeignKey("MobitelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Komponente", b =>
                {
                    b.HasOne("Dobavljac", "Dobavljac")
                        .WithMany("Komponente")
                        .HasForeignKey("DobavljacID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TipKomponente", "TipKomponente")
                        .WithMany("Komponente")
                        .HasForeignKey("TipKomponenteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Kupac", b =>
                {
                    b.HasOne("BannedKupac", "BannedKupac")
                        .WithMany("Kupac")
                        .HasForeignKey("BannedKupacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Grad", "Grad")
                        .WithMany("Kupac")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Mobiteli", b =>
                {
                    b.HasOne("OperativniSustav", "OperativniSustav")
                        .WithMany("Mobiteli")
                        .HasForeignKey("OperativniSustavId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Popusti", "Popust")
                        .WithMany()
                        .HasForeignKey("PopustId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proizvodjac", "Prozivodjac")
                        .WithMany("Mobiteli")
                        .HasForeignKey("ProizvodjacId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Narudzba", b =>
                {
                    b.HasOne("Grad", "Grad")
                        .WithMany("Narudzba")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Kupac", "Kupac")
                        .WithMany("Narudzba")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Zaposlenik", "Zaposlenik")
                        .WithMany("Narudzba")
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Novosti", b =>
                {
                    b.HasOne("Zaposlenik", "Zaposlenik")
                        .WithMany("Novosti")
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Poruka", b =>
                {
                    b.HasOne("Administrator", "Administrator")
                        .WithMany("Poruka")
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Zaposlenik", "Zaposlenik")
                        .WithMany("Poruka")
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Servis", b =>
                {
                    b.HasOne("Zaposlenik", "Zaposlenik")
                        .WithMany("Servis")
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Slika", b =>
                {
                    b.HasOne("Mobiteli", "Mobitel")
                        .WithMany("Slika")
                        .HasForeignKey("MobitelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("StavkaNarudzbe", b =>
                {
                    b.HasOne("Mobiteli", "Mobitel")
                        .WithMany("StavkaNarudzbe")
                        .HasForeignKey("MobitelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Narudzba", "Narudzba")
                        .WithMany("StavkaNarudzbe")
                        .HasForeignKey("NarudzbaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("StavkaServisa", b =>
                {
                    b.HasOne("Komponente", "Komponente")
                        .WithMany("StavkaServisa")
                        .HasForeignKey("KomponenteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Servis", "Servis")
                        .WithMany("StavkaServisa")
                        .HasForeignKey("ServisId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Zaposlenik", b =>
                {
                    b.HasOne("Grad", "Grad")
                        .WithMany("Zaposlenik")
                        .HasForeignKey("Gradid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
