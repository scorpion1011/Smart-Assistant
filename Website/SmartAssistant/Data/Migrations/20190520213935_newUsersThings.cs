using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAssistant.Data.Migrations
{
    public partial class newUsersThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersThings_Things_idThing",
                table: "UsersThings");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersThings_AspNetUsers_idUser",
                table: "UsersThings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersThings",
                table: "UsersThings");

            migrationBuilder.DropIndex(
                name: "IX_UsersThings_idThing",
                table: "UsersThings");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "UsersThings");

            migrationBuilder.DropColumn(
                name: "idThing",
                table: "UsersThings");

            migrationBuilder.AddColumn<int>(
                name: "idUserThing",
                table: "UsersThings",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UsersThings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kind",
                table: "UsersThings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "UsersThings",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersThings",
                table: "UsersThings",
                column: "idUserThing");

            migrationBuilder.CreateIndex(
                name: "IX_UsersThings_UserId",
                table: "UsersThings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersThings_AspNetUsers_UserId",
                table: "UsersThings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersThings_AspNetUsers_UserId",
                table: "UsersThings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersThings",
                table: "UsersThings");

            migrationBuilder.DropIndex(
                name: "IX_UsersThings_UserId",
                table: "UsersThings");

            migrationBuilder.DropColumn(
                name: "idUserThing",
                table: "UsersThings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UsersThings");

            migrationBuilder.DropColumn(
                name: "kind",
                table: "UsersThings");

            migrationBuilder.DropColumn(
                name: "name",
                table: "UsersThings");

            migrationBuilder.AddColumn<string>(
                name: "idUser",
                table: "UsersThings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idThing",
                table: "UsersThings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersThings",
                table: "UsersThings",
                columns: new[] { "idUser", "idThing" });

            migrationBuilder.CreateIndex(
                name: "IX_UsersThings_idThing",
                table: "UsersThings",
                column: "idThing");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersThings_Things_idThing",
                table: "UsersThings",
                column: "idThing",
                principalTable: "Things",
                principalColumn: "idThing",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersThings_AspNetUsers_idUser",
                table: "UsersThings",
                column: "idUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
