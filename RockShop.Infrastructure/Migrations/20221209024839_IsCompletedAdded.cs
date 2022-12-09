using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class IsCompletedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7691e88f-50cd-4602-aa4f-98c71b873acb", "AQAAAAEAACcQAAAAECSPmhvu9FBtG0bIckAvgbEtM5sVRFBd0U3TloIOQcUHpfmOodK62Ec9sZT/S4ahbg==", "c0d428d8-2879-4f6c-b056-0c4354c1f857" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b537c31-79d8-4f13-85ff-510446accc55", "AQAAAAEAACcQAAAAEP2JrbohfglIONlWwXS/ZM+Ymmo+sOFczB/cFZ2gAGLVzflYeAFkxe/5Z4/QaNnbxg==", "c914120c-7fb2-468b-b161-5ce561582090" });
        }
    }
}
