using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DvoranaId",
                table: "Projekcija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projekcija_DvoranaId",
                table: "Projekcija",
                column: "DvoranaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projekcija_Dvorana_DvoranaId",
                table: "Projekcija",
                column: "DvoranaId",
                principalTable: "Dvorana",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projekcija_Dvorana_DvoranaId",
                table: "Projekcija");

            migrationBuilder.DropIndex(
                name: "IX_Projekcija_DvoranaId",
                table: "Projekcija");

            migrationBuilder.DropColumn(
                name: "DvoranaId",
                table: "Projekcija");
        }
    }
}
