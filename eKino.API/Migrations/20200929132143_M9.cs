using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojSjedista",
                table: "Dvorana");

            migrationBuilder.AddColumn<int>(
                name: "BrojKolona",
                table: "Dvorana",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrojRedova",
                table: "Dvorana",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojKolona",
                table: "Dvorana");

            migrationBuilder.DropColumn(
                name: "BrojRedova",
                table: "Dvorana");

            migrationBuilder.AddColumn<short>(
                name: "BrojSjedista",
                table: "Dvorana",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
