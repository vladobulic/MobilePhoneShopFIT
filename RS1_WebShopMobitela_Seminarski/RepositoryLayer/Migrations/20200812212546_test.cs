using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 8, 12, 23, 25, 45, 473, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 8, 12, 23, 25, 45, 473, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 8, 12, 23, 25, 45, 474, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 8, 12, 23, 25, 45, 472, DateTimeKind.Local).AddTicks(902), new DateTime(2020, 8, 12, 23, 25, 45, 469, DateTimeKind.Local).AddTicks(3420) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 8, 12, 23, 21, 0, 164, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 8, 12, 23, 21, 0, 164, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 8, 12, 23, 21, 0, 165, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 8, 12, 23, 21, 0, 163, DateTimeKind.Local).AddTicks(248), new DateTime(2020, 8, 12, 23, 21, 0, 160, DateTimeKind.Local).AddTicks(1075) });
        }
    }
}
