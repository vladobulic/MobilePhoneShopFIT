using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class VladoTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddb38490-ac71-4327-a0ef-e1ccab666823");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e70f730b-60fe-48c9-acac-1fb69250aabd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f56237a4-a13c-41e0-9090-203eafe2f19e");

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 2, 19, 1, 25, 7, 112, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2021, 2, 19, 1, 25, 7, 113, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2021, 2, 19, 1, 25, 7, 111, DateTimeKind.Local).AddTicks(3589), new DateTime(2021, 2, 19, 1, 25, 7, 108, DateTimeKind.Local).AddTicks(6724) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f56237a4-a13c-41e0-9090-203eafe2f19e", "e62e7d44-5534-4d3c-95a7-a9c1f88e6390", "Administrator", "ADMINISTRATOR" },
                    { "ddb38490-ac71-4327-a0ef-e1ccab666823", "0d2b462c-8747-4b01-9650-e0fc10529c3c", "Kupac", "KUPAC" },
                    { "e70f730b-60fe-48c9-acac-1fb69250aabd", "5b8db3a2-d2b9-4283-9961-51dfd8911bf2", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 10, 9, 15, 42, 32, 173, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 10, 9, 15, 42, 32, 173, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 10, 9, 15, 42, 32, 172, DateTimeKind.Local).AddTicks(1096), new DateTime(2020, 10, 9, 15, 42, 32, 169, DateTimeKind.Local).AddTicks(1800) });
        }
    }
}
