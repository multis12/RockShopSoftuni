using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockShop.Infrastructure.Migrations
{
    public partial class DbChangesToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitars");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Neck = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Body = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Bridge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Frets = table.Column<int>(type: "int", nullable: true),
                    Adapters = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", precision: 18, scale: 2, nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Adapters", "Body", "Bridge", "CategoryId", "Description", "Frets", "ImageUrl", "InStock", "Name", "Neck", "Price", "StaffId", "TypeId" },
                values: new object[,]
                {
                    { 1, "Humbucker", "Poplar", "T102 Tremolo", 1, "Amazing guitar for beginner and intermediate players!", 24, "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp", true, "Ibanez GRG170DX BKN", "Maple", 528.00m, null, 2 },
                    { 2, "EMG® 85", "Mahogany wing", "T102 Tremolo", 1, "Amazing guitar for advanced players!", 24, "https://rockshock.eu/uploads/2021/10/01/1633091523_6553_i.webp", true, "Ibanez RGT6EX-IPT", "Wizard II Maple/Walnut neck-thru", 1721.00m, null, 2 },
                    { 3, "None", "Grand Dreadnought body", "Ovangkol Scalloped bridge", 1, "Clear sound and amazing feeling!", 20, "https://rockshock.eu/uploads/2022/04/12/1649751909_0387_i.webp", true, "Ibanez AAD100 OPN", "Low Oval Grip with Rounded Fretboard EdgeThermo Aged™ Nyatoh neck", 548.00m, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StaffId",
                table: "Products",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                table: "Products",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Adapters = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Bridge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Frets = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Neck = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", precision: 18, scale: 2, nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guitars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guitars_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Guitars_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf54221-022c-4280-9712-0cbfec63e6f1", "AQAAAAEAACcQAAAAEEqz3uwlUZh8eOPeO/ySikR7UxyECB7glsMp79EoVJboCPmTbriEDMtsKZVx490Ryg==", "7e739078-4752-487f-99ea-293a95a55aca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2423455-638c-4558-b7eb-510312d02ef1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6420296b-e938-4ff0-ac35-c26800f3a07a", "AQAAAAEAACcQAAAAEHWDD551d/nHvCKpzxC+1h4x+klg935rRK2b61x4EqGqaS80rR1B00yJm4hFQExvPA==", "45b1fc08-321c-4cbf-b2b5-89f25bdea645" });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Adapters", "Body", "Bridge", "CategoryId", "Description", "Frets", "ImageUrl", "InStock", "Name", "Neck", "Price", "StaffId", "TypeId" },
                values: new object[,]
                {
                    { 1, "Humbucker", "Poplar", "T102 Tremolo", 1, "Amazing guitar for beginner and intermediate players!", 24, "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp", true, "Ibanez GRG170DX BKN", "Maple", 528.00m, null, 2 },
                    { 2, "EMG® 85", "Mahogany wing", "T102 Tremolo", 1, "Amazing guitar for advanced players!", 24, "https://rockshock.eu/uploads/2021/10/01/1633091523_6553_i.webp", true, "Ibanez RGT6EX-IPT", "Wizard II Maple/Walnut neck-thru", 1721.00m, null, 2 },
                    { 3, "None", "Grand Dreadnought body", "Ovangkol Scalloped bridge", 1, "Clear sound and amazing feeling!", 20, "https://rockshock.eu/uploads/2022/04/12/1649751909_0387_i.webp", true, "Ibanez AAD100 OPN", "Low Oval Grip with Rounded Fretboard EdgeThermo Aged™ Nyatoh neck", 548.00m, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_CategoryId",
                table: "Guitars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_StaffId",
                table: "Guitars",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_TypeId",
                table: "Guitars",
                column: "TypeId");
        }
    }
}
