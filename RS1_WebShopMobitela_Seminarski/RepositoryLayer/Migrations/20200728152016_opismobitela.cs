using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class opismobitela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KratkiOpis",
                table: "Mobiteli",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Mobiteli",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 28, 17, 20, 16, 27, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 7, 28, 17, 20, 16, 27, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 28, 17, 20, 16, 27, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 7, 28, 17, 20, 16, 26, DateTimeKind.Local).AddTicks(923), new DateTime(2020, 7, 28, 17, 20, 16, 23, DateTimeKind.Local).AddTicks(5493) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KratkiOpis",
                table: "Mobiteli");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Mobiteli");

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
    }
}
