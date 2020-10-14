using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Komentar",
                table: "Ocijena");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Komentar",
                table: "Ocijena",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
