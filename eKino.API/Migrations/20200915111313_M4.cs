using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "FilmGlumci");

            //migrationBuilder.DropTable(
            //    name: "FilmProdukcijskeKuceService");

            migrationBuilder.DropColumn(
                name: "Ocijena1",
                table: "Ocijena");

            migrationBuilder.AddColumn<int>(
                name: "DataOcijena",
                table: "Ocijena",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "FilmGlumci",
            //    columns: table => new
            //    {
            //        FilmId = table.Column<int>(nullable: false),
            //        GlumacId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FilmGlumci", x => new { x.FilmId, x.GlumacId });
            //        table.ForeignKey(
            //            name: "FK_FilmGlumci_Film_FilmId",
            //            column: x => x.FilmId,
            //            principalTable: "Film",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_FilmGlumci_Osoba_GlumacId",
            //            column: x => x.GlumacId,
            //            principalTable: "Osoba",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FilmProdukcijskeKuce",
            //    columns: table => new
            //    {
            //        FilmId = table.Column<int>(nullable: false),
            //        ProdukcijskaKucaId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FilmProdukcijskeKuce", x => new { x.FilmId, x.ProdukcijskaKucaId });
            //        table.ForeignKey(
            //            name: "FK_FilmProdukcijskeKuce_Film_FilmId",
            //            column: x => x.FilmId,
            //            principalTable: "Film",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_FilmProdukcijskeKuce_ProdukcijskaKuca_ProdukcijskaKucaId",
            //            column: x => x.ProdukcijskaKucaId,
            //            principalTable: "ProdukcijskaKuca",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_FilmGlumci_GlumacId",
            //    table: "FilmGlumci",
            //    column: "GlumacId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FilmProdukcijskeKuce_ProdukcijskaKucaId",
            //    table: "FilmProdukcijskeKuce",
            //    column: "ProdukcijskaKucaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "FilmGlumci");

            //migrationBuilder.DropTable(
            //    name: "FilmProdukcijskeKuce");

            migrationBuilder.DropColumn(
                name: "DataOcijena",
                table: "Ocijena");

            migrationBuilder.AddColumn<int>(
                name: "Ocijena1",
                table: "Ocijena",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "FilmGlumciController",
            //    columns: table => new
            //    {
            //        FilmId = table.Column<int>(type: "int", nullable: false),
            //        GlumacId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FilmGlumciController", x => new { x.FilmId, x.GlumacId });
            //        table.ForeignKey(
            //            name: "FK_FilmGlumciController_Film_FilmId",
            //            column: x => x.FilmId,
            //            principalTable: "Film",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_FilmGlumciController_Osoba_GlumacId",
            //            column: x => x.GlumacId,
            //            principalTable: "Osoba",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FilmProdukcijskeKuceService",
            //    columns: table => new
            //    {
            //        FilmId = table.Column<int>(type: "int", nullable: false),
            //        ProdukcijskaKucaId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FilmProdukcijskeKuceService", x => new { x.FilmId, x.ProdukcijskaKucaId });
            //        table.ForeignKey(
            //            name: "FK_FilmProdukcijskeKuceService_Film_FilmId",
            //            column: x => x.FilmId,
            //            principalTable: "Film",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_FilmProdukcijskeKuceService_ProdukcijskaKuca_ProdukcijskaKucaId",
            //            column: x => x.ProdukcijskaKucaId,
            //            principalTable: "ProdukcijskaKuca",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_FilmGlumciController_GlumacId",
            //    table: "FilmGlumciController",
            //    column: "GlumacId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FilmProdukcijskeKuceService_ProdukcijskaKucaId",
            //    table: "FilmProdukcijskeKuceService",
            //    column: "ProdukcijskaKucaId");
        }
    }
}
