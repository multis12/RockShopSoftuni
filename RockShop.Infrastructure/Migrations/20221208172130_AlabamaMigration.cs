using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class AlabamaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staffs_StaffId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Staffs_StaffId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_AspNetUsers_AccountId",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderUserProducts_AccountId",
                table: "OrderUserProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderUserProducts");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Staff");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_AccountId",
                table: "Staff",
                newName: "IX_Staff_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts",
                columns: new[] { "AccountId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staff_StaffId",
                table: "Orders",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Staff_StaffId",
                table: "Products",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_AspNetUsers_AccountId",
                table: "Staff",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staff_StaffId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Staff_StaffId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_AspNetUsers_AccountId",
                table: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderUserProducts",
                table: "OrderUserProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "Staffs");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_AccountId",
                table: "Staffs",
                newName: "IX_Staffs_AccountId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d940b32-314f-44df-b0fd-f0121b1a4ebf", "AQAAAAEAACcQAAAAECrWiJ41zgxDbLP+j2Fn7eKGb7SZH7Ux0OkFRvcFngb65aK++5vbi0m0fLFHCj2lZw==", "3c3be4d5-cad9-4641-a28e-a7793ada5afe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97c4eb6d-e994-4c87-b8ff-98b613768a17", "AQAAAAEAACcQAAAAECaXzjdz6BOcL/g7Vmd9gBOQqCTSHsE4E2VcEALbZ/jIfnVWENkop4dGgJ5QjOZIHA==", "66c336ed-ac3a-4b29-ac2b-5e17c9b63144" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderUserProducts_AccountId",
                table: "OrderUserProducts",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staffs_StaffId",
                table: "Orders",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Staffs_StaffId",
                table: "Products",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_AspNetUsers_AccountId",
                table: "Staffs",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
