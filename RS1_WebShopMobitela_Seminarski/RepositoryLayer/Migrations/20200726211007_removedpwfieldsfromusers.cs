using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class removedpwfieldsfromusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Zaposlenici");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Kupci");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Administratori");

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 26, 23, 10, 7, 23, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 7, 26, 23, 10, 7, 24, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 26, 23, 10, 7, 24, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 7, 26, 23, 10, 7, 23, DateTimeKind.Local).AddTicks(1895), new DateTime(2020, 7, 26, 23, 10, 7, 20, DateTimeKind.Local).AddTicks(6087) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Zaposlenici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Kupci",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Administratori",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Administratori",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 26, 20, 18, 27, 110, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumPokusaja", "Password" },
                values: new object[] { new DateTime(2020, 7, 26, 20, 18, 27, 110, DateTimeKind.Local).AddTicks(5617), "kupac" });

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 26, 20, 18, 27, 111, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 7, 26, 20, 18, 27, 109, DateTimeKind.Local).AddTicks(1431), new DateTime(2020, 7, 26, 20, 18, 27, 106, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Zaposlenici",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "zaposlenik");
        }
    }
}
