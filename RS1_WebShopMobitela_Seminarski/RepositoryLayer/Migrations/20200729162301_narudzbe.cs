using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class narudzbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GradId",
                table: "Narudzbe",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Kanton",
                table: "Narudzbe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KontaktTelefon",
                table: "Narudzbe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opcina",
                table: "Narudzbe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostanskiBroj",
                table: "Narudzbe",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 29, 18, 23, 0, 227, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 7, 29, 18, 23, 0, 228, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 29, 18, 23, 0, 228, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 7, 29, 18, 23, 0, 226, DateTimeKind.Local).AddTicks(8152), new DateTime(2020, 7, 29, 18, 23, 0, 224, DateTimeKind.Local).AddTicks(2445) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kanton",
                table: "Narudzbe");

            migrationBuilder.DropColumn(
                name: "KontaktTelefon",
                table: "Narudzbe");

            migrationBuilder.DropColumn(
                name: "Opcina",
                table: "Narudzbe");

            migrationBuilder.DropColumn(
                name: "PostanskiBroj",
                table: "Narudzbe");

            migrationBuilder.AlterColumn<int>(
                name: "GradId",
                table: "Narudzbe",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
