using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class OrderUpdatedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Order",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c0bb516-03ec-421b-ae04-04bf5bf0be64", "AQAAAAEAACcQAAAAENDw2Y2DzvetSaK2m5bPbp6rc/YG0TrId4WmuVfaUhQFVcyc1eqUHjz8ZqlaLeJQyw==", "00b555ce-05f1-4664-819e-ef01132627b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a88449aa-7f92-4587-b7b6-c8929ef9aff6", "AQAAAAEAACcQAAAAELdked0sw0c6RL2DbizG53celpl35oD1Xu2YG05X122ZZ3D4LFf4N2QiVI9Yw8tQ3w==", "f038ac3a-0b34-4869-9fce-e9dedabcface" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Order",
                newName: "Adress");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Order",
                type: "nvarchar(60)",
                maxLength: 60,
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
    }
}
