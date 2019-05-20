using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAssistant.Data.Migrations
{
    public partial class minorfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Things",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "kind",
                table: "Things",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "name",
                table: "Things",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "kind",
                table: "Things",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
