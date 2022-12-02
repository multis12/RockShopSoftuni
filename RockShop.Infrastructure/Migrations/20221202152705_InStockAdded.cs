using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class InStockAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Guitars",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1,
                column: "InStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2,
                column: "InStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3,
                column: "InStock",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Guitars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13e330d1-a1eb-434b-b5d6-e077dc1337d6", "AQAAAAEAACcQAAAAEHtKEnDGvy7GVxCSculHNOhCzylvHPU+LaTObGTwgZkMCwZkS7KtY6nj2sPzFcIoUQ==", "d31c03db-8b5b-4fe7-8850-fa8eb199b39b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac0abb65-62db-4255-bf34-64cc0c6ca355", "AQAAAAEAACcQAAAAENmmtmkPwDEBgoZQlQvExe6lz5YQ71engW5w49FRyTd1NZ6k8QFTqbdLASp/+s+xPw==", "1179c67e-92c5-462f-a700-c129afa9cc0d" });
        }
    }
}
