using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UlogaId",
                table: "Osoba",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_UlogaId",
                table: "Osoba",
                column: "UlogaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Osoba_Uloga_UlogaId",
                table: "Osoba",
                column: "UlogaId",
                principalTable: "Uloga",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Osoba_Uloga_UlogaId",
                table: "Osoba");

            migrationBuilder.DropIndex(
                name: "IX_Osoba_UlogaId",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "UlogaId",
                table: "Osoba");
        }
    }
}
