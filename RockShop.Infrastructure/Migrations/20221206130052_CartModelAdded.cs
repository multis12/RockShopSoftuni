using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class CartModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_AccountId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => new { x.AccountId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10c8fc32-1284-456e-a231-a83d380e8dec", "AQAAAAEAACcQAAAAEJ/xFkjp6upWvv4Bu8GZLTijUmXqhsrN9XVHKkRvOLoqlhnqe6aaMfrAkXKvdbjEog==", "a426f242-81a3-4162-81ec-494ba301081f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e13bc7a-64e7-4a54-97bd-e881944ba2a6", "AQAAAAEAACcQAAAAEKqwzIreDKh4FE+HxgxOqNXvMEWOoYkZH9rvqGvMZ75NULyx+4Zc1I79TIyLFDGjrA==", "38e35e2e-35a5-45b9-ba96-34baf2a4e098" });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "543a253c-9762-4b6a-9fc4-933e0a257728", "AQAAAAEAACcQAAAAEPOX8xOUKMM9/vUkGptrFLV5w5ZvzaGQ3rpIeoN9Gvh6cIS8HZEJEjtZ6wd2D+go6g==", "a48f2095-1945-409d-9b80-82293489ca23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cedcdff6-bdcd-4ee5-8227-40f1f1a0c320", "AQAAAAEAACcQAAAAEI/+Cfal1WJSBSlC2HJWEvcePcyAsdUNg1QKWlQALUj76Hu4+5JpIoo366DrURKltQ==", "60334386-5026-4bf3-89fe-7f1d5960d81f" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccountId",
                table: "Products",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_AccountId",
                table: "Products",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
