using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class DBupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f05033db-8116-4eb3-acd1-6d1975f67de0", "AQAAAAEAACcQAAAAEPVsLsazIdh0kJ2k7BJOhEnAQ41P9uUtmAj3rsY9vQDmlGFpVxCGIrPcqY0sQzYjtA==", "e3703e71-c73a-4bad-82ab-52085de7dcf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "126e6d74-cfc2-491e-b00b-469a5c9ffd03", "AQAAAAEAACcQAAAAED4HTBpE7sVcz7o0b6N/jVPsMxTd13OOirggGEYdty2qsqkfJU7KMvxR5Q5ZL2qyhw==", "d7b55f57-7b51-4690-aa54-25460f6ea0ae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f5060d-01e0-42f5-82cf-c7ec6b60030e", "AQAAAAEAACcQAAAAELA+1lrOBqRb9ahhVo9Y9prE6JsEOvl3AgBZ2gaLpXnAJ8jejTh4bUuPuVcU8ce5kA==", "05c26160-917a-419f-b009-167172192f20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c82c50fb-b13e-43e5-8719-cd0bc2a9ed3e", "AQAAAAEAACcQAAAAEKxR23BaMQVYwcOCv7HA9ysRb7V7o6F41alB4k+pbpBjqUIncSTridv2u1PBvK7yuQ==", "69eca1c9-ddc8-4dd0-8485-e993f78d8620" });
        }
    }
}
