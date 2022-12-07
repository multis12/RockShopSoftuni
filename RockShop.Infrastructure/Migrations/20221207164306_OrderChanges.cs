using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class OrderChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Order",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Order",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b068fb0-63b0-4856-a523-2197357188f1", "AQAAAAEAACcQAAAAELTy3ZyLZyzV3il/0vEoIfrJBMhyeYaOlQqYwM2oLTdBXGTtGzYP7NxAZ+AKdMdEAg==", "495994cd-34ca-4216-9b74-89a636cde666" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6338b508-1668-4bbf-a783-7c292755029d", "AQAAAAEAACcQAAAAEMPwxMpcrl3WnvVGfQZkXDb+kEi0mTF4ukbqHfEWJB1Dr1m5Cijb4FlLuYq8FMXmwA==", "bd9fe6c8-c1d6-4424-a50b-aa6ee9ffe389" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bcb83a3-2ec1-48fc-bc7c-5fbb0aeab66a", "AQAAAAEAACcQAAAAEBA09b4xTRyOXSmdbD3/pOLYXofajxTxCnKiIu4a5gJ00uqUr441dNRY5m7QOLW3fw==", "d6568d22-7802-4f18-a50f-9addca3bbf4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13837253-52fa-4fca-b6bd-8c1d29e78855", "AQAAAAEAACcQAAAAECLMAvISJOYxNFWSiZ5sSEShjZkauGKSLqxXP8Bj8TO489JaJRmy8MvGY3z2q8anEg==", "df98a9c3-d314-4854-b008-4343e5fd0ef3" });
        }
    }
}
