using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class UpdatedAlabama : Migration
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
                values: new object[] { "7691e88f-50cd-4602-aa4f-98c71b873acb", "AQAAAAEAACcQAAAAECSPmhvu9FBtG0bIckAvgbEtM5sVRFBd0U3TloIOQcUHpfmOodK62Ec9sZT/S4ahbg==", "c0d428d8-2879-4f6c-b056-0c4354c1f857" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b537c31-79d8-4f13-85ff-510446accc55", "AQAAAAEAACcQAAAAEP2JrbohfglIONlWwXS/ZM+Ymmo+sOFczB/cFZ2gAGLVzflYeAFkxe/5Z4/QaNnbxg==", "c914120c-7fb2-468b-b161-5ce561582090" });

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
                values: new object[] { "ac7d475f-42dc-4059-b6ba-a5baaae323ff", "AQAAAAEAACcQAAAAEN+KnxJ3ATiVMEkgyD3DdReUqtNAmxFw1caUJ4emYvNaAiJ8e9m36GUeMERgucP++g==", "98d5ffc1-b5bb-43d9-92f0-dc99b5be8390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49fb3725-c730-4df7-b496-a308d10d87e1", "AQAAAAEAACcQAAAAEAyl4Bf6ztDVqza9KBAKp1lS222VXudmPN2blBXqnNfBPnVz43BZH+9t8jRLYoN37w==", "fe409162-7ce3-4059-aba9-9663d5f5e4aa" });
        }
    }
}
