using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class SeedDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "689ebdeb-34ae-4a04-9a51-1af19cb18349", "AQAAAAEAACcQAAAAEOQ+uuf80FUw7nbrG7Pww3rkibyQuqBWqIaEti91CJL0eAOG8J8aMetPGemV+dxKtA==", "a92a97a8-9a10-4bbe-9116-c507a6f3e2bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9d1d315-cc31-42b3-932e-981f237634b9", "AQAAAAEAACcQAAAAEAg5ZJaX25XYe8lpMAt9xRmG+EPyNkE4rI2e33lOq+PuboFi3hTt470RdbnxdiCm2w==", "2600a3c2-5037-4c85-a829-ec598b140d57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "173dac61-1ec9-41db-a7b9-f5b2fdc7dc8d", "AQAAAAEAACcQAAAAEABmOOl7B03FDwhGUflDcBVjRI06C/dItFT9snjaoHBnv9Fz7gj5WCza0ldiB0pxmA==", "1fb93af3-11c9-4ee8-8872-0092ad16dd1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55a29c25-3298-4c9f-8768-5a754cca1812", "AQAAAAEAACcQAAAAEJHkzlZfFdTVt/v1Jmzsg2PA4MuqZoypF5dsMbwuu/CnuKo6JtdIdc0RjSCOYD0G9A==", "40d82274-3870-4cfa-9f8f-fa76a899a92d" });
        }
    }
}
