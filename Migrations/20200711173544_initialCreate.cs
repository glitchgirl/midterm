using Microsoft.EntityFrameworkCore.Migrations;

namespace Smtih_Midterm.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    HouseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    BedRCount = table.Column<int>(nullable: false),
                    SqFt = table.Column<int>(nullable: false),
                    BathCount = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    CodeOut = table.Column<string>(nullable: true),
                    CodeIn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.HouseId);
                    table.ForeignKey(
                        name: "FK_Infos_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[] { 1, "Richmond" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[] { 2, "Columbia" });

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "HouseId", "Address", "BathCount", "BedRCount", "CodeIn", "CodeOut", "Price", "RegionId", "SqFt", "Year" },
                values: new object[] { 1, "3456 washtheroad rd", 3, 4, "unkown in", "unkown out", 12000, 1, 12345, 2019 });

            migrationBuilder.CreateIndex(
                name: "IX_Infos_RegionId",
                table: "Infos",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
