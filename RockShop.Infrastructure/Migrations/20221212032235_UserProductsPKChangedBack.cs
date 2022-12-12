using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class UserProductsPKChangedBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderUserProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29a3e286-8580-473e-aa32-d2fa449b5813", "AQAAAAEAACcQAAAAEP8g+Y7F7DBiZZrFi+er36f5KusnuNP1iGMAAsHck/6x75leXyX9gJUKY2yAFSDpuA==", "e867e15e-fdac-4d5f-9882-9f3c7bdcbe02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ff8b105-b3d9-4a0c-8b77-0a8831163077", "AQAAAAEAACcQAAAAEH1NjZSNLrLezmQjiPz6Oi5Xg5Gj943LlsJyAQ4rsCzvNy9nCWrk7ATDPQA8OfVIpA==", "6b0bb449-9e33-4e8c-87f6-5c0f85693197" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderUserProducts_AccountId",
                table: "OrderUserProducts",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderUserProducts_AccountId",
                table: "OrderUserProducts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderUserProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts",
                columns: new[] { "AccountId", "ProductId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4590bdbb-d05b-4f91-b369-679c0280b56c", "AQAAAAEAACcQAAAAEORaettYr3tDEO/KKU9+f00PwY5QTNswaJfBL+sSY5Ckkua0Z2lYOVpaGwummNddkg==", "ed50bba3-520b-422c-902a-38b3cd17d914" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c607c12a-88af-4160-a2ad-2820d9182b97", "AQAAAAEAACcQAAAAENQxk/dBsA3t5tux2u52N8pnc/YpLxh8x1gzwbBQ4TKZn/ekQHTTYRdFc3z9YOmNLA==", "01155125-1500-4f3e-992a-7bdcd2464b56" });
        }
    }
}
