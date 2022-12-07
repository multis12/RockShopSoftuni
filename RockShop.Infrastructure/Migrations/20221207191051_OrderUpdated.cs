using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class OrderUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Order",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Order",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c3f1317-902f-4a3e-a824-70f010c44283", "AQAAAAEAACcQAAAAEDCg5tsHbTdcZyFBu5Efu8PrWsav29jU+m2bcm+U33oEHkTLQAeSoHrMYER+YT9bmA==", "6896834b-dfd0-4ec2-bbeb-ffd78dd622ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41588f3e-3043-4e13-bbd6-db503d5514b7", "AQAAAAEAACcQAAAAEHRblswLPeSf4DebDde9aoyDZqqu8HOqljPQY0HbVUWZ9Ixnq0HRrgnHkrR3FGsQsA==", "56d902ed-bfdc-4f07-9fd5-3b5711801173" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Order");

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
    }
}
