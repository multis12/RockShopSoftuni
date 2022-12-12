using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class OrderUserPKChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "372c543a-2dcc-4dd0-bb22-e475b42f5739", "AQAAAAEAACcQAAAAECY7vjZMChZR2lIjcqmjfZtiNB4jQSL+pCL3iN3CU9ZVheCAGvih0aR/c1cIdg/XRg==", "af59711d-9ba2-4dc9-8ba9-027b82d3f9fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b801788a-0242-4270-901e-eb5c4fd8e027", "AQAAAAEAACcQAAAAEAo9UTB80xvGvYieqoHChQkEl2pcymY7DiNivzF2RIlUIbVuT5dyO2iguFlUPObOPA==", "57a9d7d9-3338-4e63-801f-ca0d7b01da7d" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderUserProducts_AccountId",
                table: "OrderUserProducts",
                column: "AccountId");
        }
    }
}
