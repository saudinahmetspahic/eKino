using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    DatumIsteka = table.Column<DateTime>(nullable: true),
                    MinOcijena = table.Column<int>(nullable: false),
                    MaxOcijena = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tip",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivTipa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivUloge = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivZanra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dvorana",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    BrojSjedista = table.Column<short>(nullable: false),
                    Pocetak_RadnogVremena = table.Column<DateTime>(nullable: false),
                    Kraj_RadnogVremena = table.Column<DateTime>(nullable: false),
                    GradId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dvorana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dvorana_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Biografija = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osoba_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdukcijskaKuca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdukcijskaKuca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdukcijskaKuca_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    UlogaId = table.Column<int>(nullable: false),
                    GradId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnik_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Korisnik_Uloga_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    DatumIzlaska = table.Column<DateTime>(nullable: false),
                    TipId = table.Column<int>(nullable: false),
                    ZanrId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Film_Tip_TipId",
                        column: x => x.TipId,
                        principalTable: "Tip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Film_Zanr_ZanrId",
                        column: x => x.ZanrId,
                        principalTable: "Zanr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    BrojTelefona = table.Column<string>(nullable: true),
                    DvoranaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Dvorana_DvoranaId",
                        column: x => x.DvoranaId,
                        principalTable: "Dvorana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikPaket",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    PaketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikPaket", x => new { x.KorisnikId, x.PaketId });
                    table.ForeignKey(
                        name: "FK_KorisnikPaket_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KorisnikPaket_Paket_PaketId",
                        column: x => x.PaketId,
                        principalTable: "Paket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FilmGlumciController",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    GlumacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGlumci", x => new { x.FilmId, x.GlumacId });
                    table.ForeignKey(
                        name: "FK_FilmGlumci_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilmGlumci_Osoba_GlumacId",
                        column: x => x.GlumacId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FilmProdukcijskeKuceService",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    ProdukcijskaKucaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProdukcijskeKuce", x => new { x.FilmId, x.ProdukcijskaKucaId });
                    table.ForeignKey(
                        name: "FK_FilmProdukcijskeKuce_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilmProdukcijskeKuce_ProdukcijskaKuca_ProdukcijskaKucaId",
                        column: x => x.ProdukcijskaKucaId,
                        principalTable: "ProdukcijskaKuca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FilmScenaristi",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    ScenaristId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmScenaristi", x => new { x.FilmId, x.ScenaristId });
                    table.ForeignKey(
                        name: "FK_FilmScenaristi_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FilmScenaristi_Osoba_ScenaristId",
                        column: x => x.ScenaristId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SadrzajKomentara = table.Column<string>(nullable: true),
                    KomentatorId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentar_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Komentar_Korisnik_KomentatorId",
                        column: x => x.KomentatorId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ocijena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocijena1 = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(nullable: true),
                    KomentatorId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocijena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocijena_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ocijena_Korisnik_KomentatorId",
                        column: x => x.KomentatorId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Projekcija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CijenaUlaznice = table.Column<double>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    DatumProjekcije = table.Column<DateTime>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projekcija_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KomentarReakcija",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    KomentarId = table.Column<int>(nullable: false),
                    Reakcija = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomentarReakcija", x => new { x.KomentarId, x.KorisnikId });
                    table.ForeignKey(
                        name: "FK_KomentarReakcija_Komentar_KomentarId",
                        column: x => x.KomentarId,
                        principalTable: "Komentar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KomentarReakcija_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProjekcijaDvorana",
                columns: table => new
                {
                    ProjekcijaId = table.Column<int>(nullable: false),
                    DvoranaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekcijaDvorana", x => new { x.ProjekcijaId, x.DvoranaId });
                    table.ForeignKey(
                        name: "FK_ProjekcijaDvorana_Dvorana_DvoranaId",
                        column: x => x.DvoranaId,
                        principalTable: "Dvorana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProjekcijaDvorana_Projekcija_ProjekcijaId",
                        column: x => x.ProjekcijaId,
                        principalTable: "Projekcija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKreirnja = table.Column<DateTime>(nullable: false),
                    ProjekcijaId = table.Column<int>(nullable: true),
                    KupacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Korisnik_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Projekcija_ProjekcijaId",
                        column: x => x.ProjekcijaId,
                        principalTable: "Projekcija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dvorana_GradId",
                table: "Dvorana",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_TipId",
                table: "Film",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_ZanrId",
                table: "Film",
                column: "ZanrId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmGlumci_GlumacId",
                table: "FilmGlumciController",
                column: "GlumacId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProdukcijskeKuce_ProdukcijskaKucaId",
                table: "FilmProdukcijskeKuceService",
                column: "ProdukcijskaKucaId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmScenaristi_ScenaristId",
                table: "FilmScenaristi",
                column: "ScenaristId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_FilmId",
                table: "Komentar",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_KomentatorId",
                table: "Komentar",
                column: "KomentatorId");

            migrationBuilder.CreateIndex(
                name: "IX_KomentarReakcija_KorisnikId",
                table: "KomentarReakcija",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_GradId",
                table: "Korisnik",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_UlogaId",
                table: "Korisnik",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikPaket_PaketId",
                table: "KorisnikPaket",
                column: "PaketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocijena_FilmId",
                table: "Ocijena",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocijena_KomentatorId",
                table: "Ocijena",
                column: "KomentatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_GradId",
                table: "Osoba",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdukcijskaKuca_GradId",
                table: "ProdukcijskaKuca",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcija_FilmId",
                table: "Projekcija",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekcijaDvorana_DvoranaId",
                table: "ProjekcijaDvorana",
                column: "DvoranaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KupacId",
                table: "Rezervacija",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_ProjekcijaId",
                table: "Rezervacija",
                column: "ProjekcijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_DvoranaId",
                table: "Zaposlenik",
                column: "DvoranaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGlumciController");

            migrationBuilder.DropTable(
                name: "FilmProdukcijskeKuceService");

            migrationBuilder.DropTable(
                name: "FilmScenaristi");

            migrationBuilder.DropTable(
                name: "KomentarReakcija");

            migrationBuilder.DropTable(
                name: "KorisnikPaket");

            migrationBuilder.DropTable(
                name: "Ocijena");

            migrationBuilder.DropTable(
                name: "ProjekcijaDvorana");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.DropTable(
                name: "ProdukcijskaKuca");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Paket");

            migrationBuilder.DropTable(
                name: "Projekcija");

            migrationBuilder.DropTable(
                name: "Dvorana");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Tip");

            migrationBuilder.DropTable(
                name: "Zanr");
        }
    }
}
