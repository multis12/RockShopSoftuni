using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class OrderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Order_AccountId",
                table: "Order",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StaffId",
                table: "Order",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f05033db-8116-4eb3-acd1-6d1975f67de0", "AQAAAAEAACcQAAAAEPVsLsazIdh0kJ2k7BJOhEnAQ41P9uUtmAj3rsY9vQDmlGFpVxCGIrPcqY0sQzYjtA==", "e3703e71-c73a-4bad-82ab-52085de7dcf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "126e6d74-cfc2-491e-b00b-469a5c9ffd03", "AQAAAAEAACcQAAAAED4HTBpE7sVcz7o0b6N/jVPsMxTd13OOirggGEYdty2qsqkfJU7KMvxR5Q5ZL2qyhw==", "d7b55f57-7b51-4690-aa54-25460f6ea0ae" });
        }
    }
}
