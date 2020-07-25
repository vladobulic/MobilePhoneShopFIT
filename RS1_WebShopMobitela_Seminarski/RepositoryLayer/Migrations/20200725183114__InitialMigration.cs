using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administratori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsSuperAdmin = table.Column<bool>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BannedKupci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumDo = table.Column<DateTime>(nullable: false),
                    Zauvijek = table.Column<bool>(nullable: false),
                    Razlog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannedKupci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Broj = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true),
                    RequestPath = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    ActionDescriptor = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperativniSustavi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Verzija = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperativniSustavi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Popusti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOd = table.Column<DateTime>(nullable: false),
                    DatumDo = table.Column<DateTime>(nullable: false),
                    PostotakPopusta = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popusti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Broj = table.Column<string>(nullable: true),
                    Poruka = table.Column<string>(nullable: true),
                    Dodatnisadrzaj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipKomponente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKomponente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zupanije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zupanije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mobiteli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Megapikseli = table.Column<float>(nullable: false),
                    Ram_Gb = table.Column<float>(nullable: false),
                    StanjeNaSkladistu = table.Column<int>(nullable: false),
                    EksternaMemorija = table.Column<bool>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    KapacitetBaterije = table.Column<int>(nullable: false),
                    Tezina = table.Column<int>(nullable: false),
                    Rezolucija = table.Column<string>(nullable: true),
                    DijagonalaEkrana = table.Column<float>(nullable: false),
                    Procesor = table.Column<string>(nullable: true),
                    Graficka = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProizvodjacId = table.Column<int>(nullable: false),
                    OperativniSustavId = table.Column<int>(nullable: false),
                    PopustId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobiteli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobiteli_OperativniSustavi_OperativniSustavId",
                        column: x => x.OperativniSustavId,
                        principalTable: "OperativniSustavi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mobiteli_Popusti_PopustId",
                        column: x => x.PopustId,
                        principalTable: "Popusti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mobiteli_Proizvodjaci_ProizvodjacId",
                        column: x => x.ProizvodjacId,
                        principalTable: "Proizvodjaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komponente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    KolicinaNaSkladistu = table.Column<int>(nullable: false),
                    PreporucenaCijena = table.Column<double>(nullable: false),
                    TipKomponenteId = table.Column<int>(nullable: false),
                    DobavljacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komponente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komponente_Dobavljaci_DobavljacID",
                        column: x => x.DobavljacID,
                        principalTable: "Dobavljaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komponente_TipKomponente_TipKomponenteId",
                        column: x => x.TipKomponenteId,
                        principalTable: "TipKomponente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<int>(nullable: false),
                    ZupanijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradovi_Zupanije_ZupanijaId",
                        column: x => x.ZupanijaId,
                        principalTable: "Zupanije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    MobitelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slike_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    BrojPokusaja = table.Column<int>(nullable: false),
                    DatumPokusaja = table.Column<DateTime>(nullable: false),
                    BrojMobitela = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: false),
                    BannedKupacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupci_BannedKupci_BannedKupacId",
                        column: x => x.BannedKupacId,
                        principalTable: "BannedKupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kupci_Gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    Gradid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaposlenici_Gradovi_Gradid",
                        column: x => x.Gradid,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MobitelId = table.Column<int>(nullable: false),
                    KupacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentari_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentari_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UkupnaCijena = table.Column<double>(nullable: false),
                    Ulica = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    Stanje = table.Column<int>(nullable: false),
                    KupacId = table.Column<int>(nullable: false),
                    GradId = table.Column<int>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SadrzajTekst = table.Column<string>(nullable: true),
                    Naslov = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Novosti_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subjekt = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    DatumSlanja = table.Column<DateTime>(nullable: false),
                    Procitano = table.Column<bool>(nullable: false),
                    Hitno = table.Column<bool>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: false),
                    AdministratorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poruke_Administratori_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administratori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poruke_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servisi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPrijema = table.Column<DateTime>(nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    CijenaUkupno = table.Column<double>(nullable: false),
                    StanjeServisa = table.Column<int>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servisi_Zaposlenici_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkeNarudzbe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    MobitelId = table.Column<int>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeNarudzbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkeNarudzbe_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkeNarudzbe_Narudzbe_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkaServisa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cijena = table.Column<double>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    ServisId = table.Column<int>(nullable: false),
                    KomponenteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaServisa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaServisa_Komponente_KomponenteId",
                        column: x => x.KomponenteId,
                        principalTable: "Komponente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkaServisa_Servisi_ServisId",
                        column: x => x.ServisId,
                        principalTable: "Servisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Administratori",
                columns: new[] { "Id", "Email", "Ime", "IsSuperAdmin", "Password", "Prezime" },
                values: new object[] { 1, "admin@admin.com", "admin", true, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Dobavljaci",
                columns: new[] { "Id", "Broj", "Ime", "Mail" },
                values: new object[] { 1, "063323718", "Samsung", "dobavljac@dobavljac.com" });

            migrationBuilder.InsertData(
                table: "OperativniSustavi",
                columns: new[] { "Id", "Naziv", "Verzija" },
                values: new object[] { 1, "Android", 11f });

            migrationBuilder.InsertData(
                table: "Popusti",
                columns: new[] { "Id", "DatumDo", "DatumOd", "PostotakPopusta" },
                values: new object[] { 1, new DateTime(2020, 7, 25, 20, 31, 13, 656, DateTimeKind.Local).AddTicks(3134), new DateTime(2020, 7, 25, 20, 31, 13, 653, DateTimeKind.Local).AddTicks(7492), 5f });

            migrationBuilder.InsertData(
                table: "Proizvodjaci",
                columns: new[] { "Id", "Naziv" },
                values: new object[] { 1, "Samsung" });

            migrationBuilder.InsertData(
                table: "Zupanije",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Hercegovacko-Neretvanska" },
                    { 2, "Zapadno-Hercegovacka" }
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "Id", "Naziv", "PostanskiBroj", "ZupanijaId" },
                values: new object[,]
                {
                    { 1, "Citluk", 88260, 1 },
                    { 2, "Siroki Brijeg", 88520, 2 }
                });

            migrationBuilder.InsertData(
                table: "Mobiteli",
                columns: new[] { "Id", "Cijena", "DijagonalaEkrana", "EksternaMemorija", "Graficka", "IsDeleted", "KapacitetBaterije", "Megapikseli", "Naziv", "OperativniSustavId", "PopustId", "Procesor", "ProizvodjacId", "Ram_Gb", "Rezolucija", "StanjeNaSkladistu", "Tezina" },
                values: new object[,]
                {
                    { 1, 1200.0, 6.1f, true, "Ardent", false, 3200, 12.3f, "S10", 1, 1, "Xenon A5G", 1, 8f, "FULL HD IPS", 10, 320 },
                    { 2, 1200.0, 6.1f, true, "Ardent", false, 3200, 12.3f, "S20", 1, 1, "Xenon A5G", 1, 8f, "FULL HD IPS", 10, 320 },
                    { 3, 1200.0, 6.1f, true, "Ardent", false, 3200, 12.3f, "A50", 1, 1, "Xenon A5G", 1, 8f, "FULL HD IPS", 10, 320 }
                });

            migrationBuilder.InsertData(
                table: "Kupci",
                columns: new[] { "Id", "BannedKupacId", "BrojMobitela", "BrojPokusaja", "DatumPokusaja", "Email", "GradId", "Ime", "Password", "Prezime" },
                values: new object[] { 1, null, "063525555", 0, new DateTime(2020, 7, 25, 20, 31, 13, 657, DateTimeKind.Local).AddTicks(6674), "kupac@kupac.com", 1, "kupac", "kupac", "kupic" });

            migrationBuilder.InsertData(
                table: "Zaposlenici",
                columns: new[] { "Id", "Email", "Gradid", "Ime", "Password", "Prezime", "Ulica", "isDeleted" },
                values: new object[] { 1, "Zaposlenik@zaposlenik.com", 1, "Zaposlenik", "zaposlenik", "Zaposlenko", "markovac", false });

            migrationBuilder.InsertData(
                table: "Komentari",
                columns: new[] { "Id", "Datum", "IsDeleted", "KupacId", "MobitelId", "Sadrzaj" },
                values: new object[] { 1, new DateTime(2020, 7, 25, 20, 31, 13, 657, DateTimeKind.Local).AddTicks(2277), false, 1, 1, null });

            migrationBuilder.InsertData(
                table: "Novosti",
                columns: new[] { "Id", "Datum", "Naslov", "SadrzajTekst", "ZaposlenikId" },
                values: new object[] { 1, new DateTime(2020, 7, 25, 20, 31, 13, 658, DateTimeKind.Local).AddTicks(2172), "Novi iPhone stigao u BiH", "ok mobitel", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_ZupanijaId",
                table: "Gradovi",
                column: "ZupanijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_KupacId",
                table: "Komentari",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_MobitelId",
                table: "Komentari",
                column: "MobitelId");

            migrationBuilder.CreateIndex(
                name: "IX_Komponente_DobavljacID",
                table: "Komponente",
                column: "DobavljacID");

            migrationBuilder.CreateIndex(
                name: "IX_Komponente_TipKomponenteId",
                table: "Komponente",
                column: "TipKomponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_BannedKupacId",
                table: "Kupci",
                column: "BannedKupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_GradId",
                table: "Kupci",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiteli_OperativniSustavId",
                table: "Mobiteli",
                column: "OperativniSustavId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiteli_PopustId",
                table: "Mobiteli",
                column: "PopustId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiteli_ProizvodjacId",
                table: "Mobiteli",
                column: "ProizvodjacId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_GradId",
                table: "Narudzbe",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_KupacId",
                table: "Narudzbe",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_ZaposlenikId",
                table: "Narudzbe",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_ZaposlenikId",
                table: "Novosti",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_AdministratorId",
                table: "Poruke",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_ZaposlenikId",
                table: "Poruke",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Servisi_ZaposlenikId",
                table: "Servisi",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Slike_MobitelId",
                table: "Slike",
                column: "MobitelId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaServisa_KomponenteId",
                table: "StavkaServisa",
                column: "KomponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaServisa_ServisId",
                table: "StavkaServisa",
                column: "ServisId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbe_MobitelId",
                table: "StavkeNarudzbe",
                column: "MobitelId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbe_NarudzbaId",
                table: "StavkeNarudzbe",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenici_Gradid",
                table: "Zaposlenici",
                column: "Gradid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "Slike");

            migrationBuilder.DropTable(
                name: "SmsLog");

            migrationBuilder.DropTable(
                name: "StavkaServisa");

            migrationBuilder.DropTable(
                name: "StavkeNarudzbe");

            migrationBuilder.DropTable(
                name: "Administratori");

            migrationBuilder.DropTable(
                name: "Komponente");

            migrationBuilder.DropTable(
                name: "Servisi");

            migrationBuilder.DropTable(
                name: "Mobiteli");

            migrationBuilder.DropTable(
                name: "Narudzbe");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "TipKomponente");

            migrationBuilder.DropTable(
                name: "OperativniSustavi");

            migrationBuilder.DropTable(
                name: "Popusti");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Zaposlenici");

            migrationBuilder.DropTable(
                name: "BannedKupci");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Zupanije");
        }
    }
}
