using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAssistant.Data.Migrations
{
    public partial class manytomanyUserThing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersThings",
                columns: table => new
                {
                    idUser = table.Column<string>(nullable: false),
                    idThing = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersThings", x => new { x.idUser, x.idThing });
                    table.ForeignKey(
                        name: "FK_UsersThings_Things_idThing",
                        column: x => x.idThing,
                        principalTable: "Things",
                        principalColumn: "idThing",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersThings_AspNetUsers_idUser",
                        column: x => x.idUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersThings_idThing",
                table: "UsersThings",
                column: "idThing");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersThings");
        }
    }
}
