using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class GuitarModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instock",
                table: "Guitars");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Staffs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Guitars",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13e330d1-a1eb-434b-b5d6-e077dc1337d6", "AQAAAAEAACcQAAAAEHtKEnDGvy7GVxCSculHNOhCzylvHPU+LaTObGTwgZkMCwZkS7KtY6nj2sPzFcIoUQ==", "d31c03db-8b5b-4fe7-8850-fa8eb199b39b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac0abb65-62db-4255-bf34-64cc0c6ca355", "AQAAAAEAACcQAAAAENmmtmkPwDEBgoZQlQvExe6lz5YQ71engW5w49FRyTd1NZ6k8QFTqbdLASp/+s+xPw==", "1179c67e-92c5-462f-a700-c129afa9cc0d" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+35988888");

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_StaffId",
                table: "Guitars",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_Staffs_StaffId",
                table: "Guitars",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_Staffs_StaffId",
                table: "Guitars");

            migrationBuilder.DropIndex(
                name: "IX_Guitars_StaffId",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Guitars");

            migrationBuilder.AddColumn<bool>(
                name: "Instock",
                table: "Guitars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7647a3-df95-4886-a60c-d4e7749c2c52", "AQAAAAEAACcQAAAAEDVn92vF/2MP9zBb39mxXbdpg8GaVy4ZgpEhYMApxWgjDdRZzQhJ4wGKTrtPu1QqzA==", "2da64613-917f-4b19-bda7-a8f813a8a514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce315297-0e44-4cb4-a1f9-d897aef64ca2", "AQAAAAEAACcQAAAAEJj8zieOSd+/6DmWsS8Sxtzf1q1j/8rqtW8EDCrOcVnxX0iBLzPWIj2kBck8cqF1mQ==", "600cf03e-f355-4f50-a5d5-936db96778da" });

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Instock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Instock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Instock",
                value: true);
        }
    }
}
