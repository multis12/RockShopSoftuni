using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class ProductIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1569b47-939a-4fb1-9557-5ed21522e7af", "AQAAAAEAACcQAAAAEM1bmvX7tbz+ma/ZPauqOEaHkLNVExPRuP/tdVoqW0APmxGhSNhHgvzOr2oA3KAJcA==", "dda611ec-b901-4c75-8395-72312a386f0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b8b5c9-7501-404a-acc0-404974698e88", "AQAAAAEAACcQAAAAEHlQGfEAPlSyX7yvRKwdKSh2M4Q3ebr0U3IRAv1d7DRmN+7g/EIBp0uSXeKczfXrDg==", "5ba72803-7452-4ec1-9a4d-61d0f20c9ca4" });
        }
    }
}
