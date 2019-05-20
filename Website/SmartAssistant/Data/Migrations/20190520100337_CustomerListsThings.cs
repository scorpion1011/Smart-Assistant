using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAssistant.Data.Migrations
{
    public partial class CustomerListsThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerLists",
                columns: table => new
                {
                    idList = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLists", x => x.idList);
                });

            migrationBuilder.CreateTable(
                name: "Things",
                columns: table => new
                {
                    idThing = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<int>(nullable: false),
                    kind = table.Column<int>(nullable: false),
                    CustomerListidList = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Things", x => x.idThing);
                    table.ForeignKey(
                        name: "FK_Things_CustomerLists_CustomerListidList",
                        column: x => x.CustomerListidList,
                        principalTable: "CustomerLists",
                        principalColumn: "idList",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Things_CustomerListidList",
                table: "Things",
                column: "CustomerListidList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Things");

            migrationBuilder.DropTable(
                name: "CustomerLists");
        }
    }
}
