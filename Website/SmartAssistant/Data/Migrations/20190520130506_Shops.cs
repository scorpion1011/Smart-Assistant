using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAssistant.Data.Migrations
{
    public partial class Shops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    idShop = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    latitude = table.Column<int>(nullable: false),
                    longitude = table.Column<int>(nullable: false),
                    area = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.idShop);
                    table.ForeignKey(
                        name: "FK_Shops_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingAtShop",
                columns: table => new
                {
                    idShop = table.Column<int>(nullable: false),
                    idThing = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingAtShop", x => new { x.idShop, x.idThing });
                    table.ForeignKey(
                        name: "FK_ThingAtShop_Shops_idShop",
                        column: x => x.idShop,
                        principalTable: "Shops",
                        principalColumn: "idShop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThingAtShop_Things_idThing",
                        column: x => x.idThing,
                        principalTable: "Things",
                        principalColumn: "idThing",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shops_UserId",
                table: "Shops",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ThingAtShop_idThing",
                table: "ThingAtShop",
                column: "idThing");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThingAtShop");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
