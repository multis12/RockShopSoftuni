using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class SeedDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa99b1e-d818-42ec-b54e-132c16b6f3c6", "AQAAAAEAACcQAAAAEDLssTMCL/NEPelqXL6YMJDOaM/MQXRetlNrB8Ag5usTyEWw1Xp2z9g0Fv7WoRQlpg==", "80009c95-76de-4613-919b-591e18c79317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96996d9f-4d12-40ff-ac21-a2183c5e82bc", "AQAAAAEAACcQAAAAEJ5jT8chx5aGiFS7KnXyD6OXwIHvMGCkv4x1dM3puTUOYsjwjnTj3AcMGXt/U/uuoQ==", "b1507f62-605c-431e-8972-f02e0d70afc5" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Guitar" },
                    { 2, "Ukulele" },
                    { 3, "Harmonica" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Acoustic" },
                    { 2, "Electric" },
                    { 3, "Electroacoustic" }
                });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Adapters", "Body", "Bridge", "CategoryId", "Description", "Frets", "ImageUrl", "Instock", "Name", "Neck", "Price", "TypeId" },
                values: new object[] { 1, "Humbucker", "Poplar", "T102 Tremolo", 1, "Amazing guitar for beginner and intermediate players!", 24, "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp", true, "Ibanez GRG170DX BKN", "Maple", 528.00m, 2 });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Adapters", "Body", "Bridge", "CategoryId", "Description", "Frets", "ImageUrl", "Instock", "Name", "Neck", "Price", "TypeId" },
                values: new object[] { 2, "EMG® 85", "Mahogany wing", "T102 Tremolo", 1, "Amazing guitar for advanced players!", 24, "https://rockshock.eu/uploads/2021/10/01/1633091523_6553_i.webp", true, "Ibanez RGT6EX-IPT", "Wizard II Maple/Walnut neck-thru", 1721.00m, 2 });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Adapters", "Body", "Bridge", "CategoryId", "Description", "Frets", "ImageUrl", "Instock", "Name", "Neck", "Price", "TypeId" },
                values: new object[] { 3, "None", "Grand Dreadnought body", "Ovangkol Scalloped bridge", 1, "Clear sound and amazing feeling!", 20, "https://rockshock.eu/uploads/2022/04/12/1649751909_0387_i.webp", true, "Ibanez AAD100 OPN", "Low Oval Grip with Rounded Fretboard EdgeThermo Aged™ Nyatoh neck", 548.00m, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
