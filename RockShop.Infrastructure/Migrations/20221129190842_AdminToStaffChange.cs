using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class AdminToStaffChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "f2423455-638c-4558-b7eb-510312d02ef1" });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                table: "Staffs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "f2423455-638c-4558-b7eb-510312d02ef1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa99b1e-d818-42ec-b54e-132c16b6f3c6", "AQAAAAEAACcQAAAAEDLssTMCL/NEPelqXL6YMJDOaM/MQXRetlNrB8Ag5usTyEWw1Xp2z9g0Fv7WoRQlpg==", "80009c95-76de-4613-919b-591e18c79317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96996d9f-4d12-40ff-ac21-a2183c5e82bc", "AQAAAAEAACcQAAAAEJ5jT8chx5aGiFS7KnXyD6OXwIHvMGCkv4x1dM3puTUOYsjwjnTj3AcMGXt/U/uuoQ==", "b1507f62-605c-431e-8972-f02e0d70afc5" });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");
        }
    }
}
