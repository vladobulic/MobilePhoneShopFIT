using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class userfks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Zaposlenici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Kupci",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Administratori",
                nullable: true);

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
                column: "DatumPokusaja",
                value: new DateTime(2020, 7, 26, 20, 18, 27, 110, DateTimeKind.Local).AddTicks(5617));

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

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenici_ApplicationUserId",
                table: "Zaposlenici",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_ApplicationUserId",
                table: "Kupci",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Administratori_ApplicationUserId",
                table: "Administratori",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administratori_AspNetUsers_ApplicationUserId",
                table: "Administratori",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupci_AspNetUsers_ApplicationUserId",
                table: "Kupci",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zaposlenici_AspNetUsers_ApplicationUserId",
                table: "Zaposlenici",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administratori_AspNetUsers_ApplicationUserId",
                table: "Administratori");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupci_AspNetUsers_ApplicationUserId",
                table: "Kupci");

            migrationBuilder.DropForeignKey(
                name: "FK_Zaposlenici_AspNetUsers_ApplicationUserId",
                table: "Zaposlenici");

            migrationBuilder.DropIndex(
                name: "IX_Zaposlenici_ApplicationUserId",
                table: "Zaposlenici");

            migrationBuilder.DropIndex(
                name: "IX_Kupci_ApplicationUserId",
                table: "Kupci");

            migrationBuilder.DropIndex(
                name: "IX_Administratori_ApplicationUserId",
                table: "Administratori");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Zaposlenici");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Kupci");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Administratori");

            migrationBuilder.UpdateData(
                table: "Komentari",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 26, 19, 34, 53, 762, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumPokusaja",
                value: new DateTime(2020, 7, 26, 19, 34, 53, 762, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "Id",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2020, 7, 26, 19, 34, 53, 763, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Popusti",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumDo", "DatumOd" },
                values: new object[] { new DateTime(2020, 7, 26, 19, 34, 53, 761, DateTimeKind.Local).AddTicks(3590), new DateTime(2020, 7, 26, 19, 34, 53, 758, DateTimeKind.Local).AddTicks(4699) });
        }
    }
}
