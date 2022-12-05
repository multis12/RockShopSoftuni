using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class UpdatedTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf54221-022c-4280-9712-0cbfec63e6f1", "AQAAAAEAACcQAAAAEEqz3uwlUZh8eOPeO/ySikR7UxyECB7glsMp79EoVJboCPmTbriEDMtsKZVx490Ryg==", "7e739078-4752-487f-99ea-293a95a55aca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6420296b-e938-4ff0-ac35-c26800f3a07a", "AQAAAAEAACcQAAAAEHWDD551d/nHvCKpzxC+1h4x+klg935rRK2b61x4EqGqaS80rR1B00yJm4hFQExvPA==", "45b1fc08-321c-4cbf-b2b5-89f25bdea645" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59323fd1-a1ea-40d1-9835-1f3231af7c35", "AQAAAAEAACcQAAAAEOhW8kNd6E90Zv3m5DFlN1N4P9CW4evAHWtfxQiX9yj69joTb7rmX5icvnOmb6vfDA==", "c1d0c7cc-2c55-4c52-8469-2c6e11f2a84a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b422535b-5c4d-4f9d-95a7-a6b4d3550335", "AQAAAAEAACcQAAAAEJ7wHQVY4a1NxuIiCwVjU11suM+L3oZ9uaSevQnJQgGu9io29mA7RPgETNK53GIfNQ==", "da2420be-2f13-422e-bb3b-0106c46b6549" });
        }
    }
}
