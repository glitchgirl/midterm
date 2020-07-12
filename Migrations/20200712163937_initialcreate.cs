using Microsoft.EntityFrameworkCore.Migrations;

namespace Smtih_Midterm.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoFilter = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pic1 = table.Column<string>(nullable: true),
                    Pic2 = table.Column<string>(nullable: true),
                    Pic3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoFilter);
                });

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
                    PhotoFilter = table.Column<int>(nullable: false),
                    PhotosPhotoFilter = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    BedRCount = table.Column<int>(nullable: false),
                    SqFt = table.Column<int>(nullable: false),
                    BathCount = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    CodeOut = table.Column<string>(nullable: true),
                    Heating = table.Column<string>(nullable: true),
                    AC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.HouseId);
                    table.ForeignKey(
                        name: "FK_Infos_Photos_PhotosPhotoFilter",
                        column: x => x.PhotosPhotoFilter,
                        principalTable: "Photos",
                        principalColumn: "PhotoFilter",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Infos_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoFilter", "Pic1", "Pic2", "Pic3" },
                values: new object[,]
                {
                    { 1, "bathroom1.jpg", "bedroom1.jpg", "kitchen1.jpg" },
                    { 2, "bathroom2.jpg", "bedroom2.jpg", "kitchen2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[,]
                {
                    { 1, "Richmond" },
                    { 2, "Columbia" }
                });

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "HouseId", "AC", "Address", "BathCount", "BedRCount", "CodeOut", "Heating", "PhotoFilter", "PhotosPhotoFilter", "Price", "RegionId", "SqFt", "Year" },
                values: new object[] { 1, "Central", "4340 Peach Orchard Rd, Hephzibah, GA 30815", 3, 7, "out1.jpg", "Forced air, Heat pump", 1, null, 325000, 1, 5726, 1929 });

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "HouseId", "AC", "Address", "BathCount", "BedRCount", "CodeOut", "Heating", "PhotoFilter", "PhotosPhotoFilter", "Price", "RegionId", "SqFt", "Year" },
                values: new object[] { 2, "Central", "1105 Fawn Forest Rd, Grovetown, GA", 3, 5, "out2.jpg", "Heat pump", 2, null, 300000, 2, 3371, 2018 });

            migrationBuilder.CreateIndex(
                name: "IX_Infos_PhotosPhotoFilter",
                table: "Infos",
                column: "PhotosPhotoFilter");

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
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
