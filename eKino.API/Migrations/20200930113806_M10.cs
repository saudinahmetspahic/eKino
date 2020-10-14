using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KorisnikPaket",
                table: "KorisnikPaket");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KorisnikPaket",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KorisnikPaket",
                table: "KorisnikPaket",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikPaket_KorisnikId",
                table: "KorisnikPaket",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KorisnikPaket",
                table: "KorisnikPaket");

            migrationBuilder.DropIndex(
                name: "IX_KorisnikPaket_KorisnikId",
                table: "KorisnikPaket");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KorisnikPaket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KorisnikPaket",
                table: "KorisnikPaket",
                columns: new[] { "KorisnikId", "PaketId" });
        }
    }
}
