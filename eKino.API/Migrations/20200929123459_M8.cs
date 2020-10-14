using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SjedisteKolona",
                table: "Rezervacija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SjedisteRed",
                table: "Rezervacija",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SjedisteKolona",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "SjedisteRed",
                table: "Rezervacija");
        }
    }
}
