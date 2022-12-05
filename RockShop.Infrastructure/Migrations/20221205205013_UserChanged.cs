using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class UserChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_AspNetUsers_UserId",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Staffs",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_UserId",
                table: "Staffs",
                newName: "IX_Staffs_AccountId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Holes",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tune",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_AspNetUsers_AccountId",
                table: "Staffs",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_AccountId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_AspNetUsers_AccountId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Holes",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Tune",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Staffs",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_AccountId",
                table: "Staffs",
                newName: "IX_Staffs_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c245fa7-26e4-4ffc-af47-533dd58b1061", "AQAAAAEAACcQAAAAEGMjqy8gJ5bXIKlZun05YDMGIpj9Wp3McnEAwH/q+rSuTpFpAe4LCBX834kAQGFHUw==", "ddfa2667-e7ea-4820-8f39-fb40fc605071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e397add-52a8-4d1d-82fe-8917f5e74a02", "AQAAAAEAACcQAAAAELjjntzsicmO3CzghG9B+P0kNK1S/5plRNeMy6LkoQ1R5IxioQCmqrBFvF4pfItPdQ==", "b9a38c14-0d85-4561-b8f1-aca7909c81b4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_AspNetUsers_UserId",
                table: "Staffs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
