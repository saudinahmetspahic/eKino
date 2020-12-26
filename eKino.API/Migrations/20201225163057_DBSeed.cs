using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class DBSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Sarajevo" },
                    { 2, "Zenica" },
                    { 3, "Mostar" },
                    { 4, "Berlin" },
                    { 5, "London" },
                    { 6, "New York" }
                });

            migrationBuilder.InsertData(
                table: "Paket",
                columns: new[] { "Id", "Cijena", "DatumIsteka", "DatumKreiranja", "MaxOcijena", "Opis" },
                values: new object[,]
                {
                    { 1, 11.0, new DateTime(2021, 1, 11, 17, 30, 56, 272, DateTimeKind.Local).AddTicks(9533), new DateTime(2020, 12, 20, 17, 30, 56, 273, DateTimeKind.Local).AddTicks(1983), 4, "Paket 1" },
                    { 2, 24.0, new DateTime(2021, 1, 13, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1249), new DateTime(2020, 12, 15, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1328), 3, "Paket 2" },
                    { 3, 39.0, new DateTime(2021, 1, 15, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1500), new DateTime(2020, 12, 10, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1511), 5, "Paket 3" }
                });

            migrationBuilder.InsertData(
                table: "Tip",
                columns: new[] { "Id", "NazivTipa" },
                values: new object[,]
                {
                    { 3, "Dokumentarac" },
                    { 2, "Animirani" },
                    { 1, "Igrani" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "Id", "NazivUloge" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Guest" },
                    { 3, "Glumac" },
                    { 4, "Scenarista" }
                });

            migrationBuilder.InsertData(
                table: "Zanr",
                columns: new[] { "Id", "NazivZanra" },
                values: new object[,]
                {
                    { 1, "Akcija" },
                    { 2, "Drama" },
                    { 3, "Komendija" },
                    { 4, "Horor" },
                    { 5, "Sci-Fi" }
                });

            migrationBuilder.InsertData(
                table: "Dvorana",
                columns: new[] { "Id", "BrojKolona", "BrojRedova", "GradId", "Kraj_RadnogVremena", "Naziv", "Pocetak_RadnogVremena" },
                values: new object[,]
                {
                    { 1, 8, 4, 1, new DateTime(2020, 12, 26, 1, 30, 56, 267, DateTimeKind.Local).AddTicks(13), "Dvorana 1", new DateTime(2020, 12, 25, 17, 30, 56, 262, DateTimeKind.Local).AddTicks(7171) },
                    { 2, 9, 5, 2, new DateTime(2020, 12, 26, 4, 30, 56, 267, DateTimeKind.Local).AddTicks(4434), "Dvorana 2", new DateTime(2020, 12, 25, 20, 30, 56, 267, DateTimeKind.Local).AddTicks(4396) },
                    { 3, 10, 6, 3, new DateTime(2020, 12, 26, 7, 30, 56, 267, DateTimeKind.Local).AddTicks(4574), "Dvorana 3", new DateTime(2020, 12, 25, 23, 30, 56, 267, DateTimeKind.Local).AddTicks(4566) }
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "DatumIzlaska", "Link", "Naziv", "Opis", "Slika", "TipId", "ZanrId" },
                values: new object[,]
                {
                    { 7, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7641), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 7", "Kratki opis filma 7, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 2 },
                    { 12, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8064), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 12", "Kratki opis filma 12, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 3, 2 },
                    { 17, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8295), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 17", "Kratki opis filma 17, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 2 },
                    { 3, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7445), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 3", "Kratki opis filma 3, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 3, 3 },
                    { 8, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7696), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 8", "Kratki opis filma 8, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 3 },
                    { 13, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8124), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 13", "Kratki opis filma 13, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 3 },
                    { 4, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7494), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 4", "Kratki opis filma 4, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 4 },
                    { 2, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7323), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 2", "Kratki opis filma 2, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 2 },
                    { 9, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7751), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 9", "Kratki opis filma 9, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 3, 4 },
                    { 14, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8167), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 14", "Kratki opis filma 14, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 4 },
                    { 19, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8390), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 19", "Kratki opis filma 19, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 4 },
                    { 5, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7540), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 5", "Kratki opis filma 5, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 5 },
                    { 10, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7800), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 10", "Kratki opis filma 10, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 5 },
                    { 18, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8342), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 18", "Kratki opis filma 18, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 3, 3 },
                    { 16, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8252), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 16", "Kratki opis filma 16, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 1 },
                    { 11, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7847), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 11", "Kratki opis filma 11, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 1 },
                    { 6, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7595), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 6", "Kratki opis filma 6, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 3, 1 },
                    { 1, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(5785), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 1", "Kratki opis filma 1, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 1, 1 },
                    { 15, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8210), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 15", "Kratki opis filma 15, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 3, 5 },
                    { 20, new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8432), "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4", "Film 20", "Kratki opis filma 20, opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.", null, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "Id", "DatumRegistracije", "DatumRodjenja", "Email", "GradId", "Ime", "LozinkaHash", "LozinkaSalt", "Prezime", "SlanjeEmaila", "UlogaId" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4473), new DateTime(1997, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4465), "user3@mail.com", 2, "Korisnik", "", "", "3", true, 2 },
                    { 3, new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4420), new DateTime(1997, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4412), "user2@mail.com", 3, "Korisnik", "", "", "2", true, 2 },
                    { 2, new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4340), new DateTime(1997, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4258), "user1@mail.com", 4, "Korisnik", "", "", "1", true, 2 },
                    { 1, new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(2662), new DateTime(1995, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(7959), "admin@mail.com", 2, "Admin", "", "", "Admin", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Osoba",
                columns: new[] { "Id", "Biografija", "DatumRodjenja", "GradId", "Ime", "Prezime", "UlogaId" },
                values: new object[,]
                {
                    { 6, "Christopher Edward Nolan, (born 30 July 1970) is an English-American film director, screenwriter, and producer, who is known for making personal, distinctive films within the Hollywood mainstream.", new DateTime(1982, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3991), 4, "Christopher", "Nolan", 4 },
                    { 5, "Joel Coen and Ethan Coen, collectively referred to as the Coen Brothers, are American film directors, producers, screenwriters, and editors. Their films span many genres and styles, which they frequently subvert or parody.", new DateTime(1986, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3943), 6, "Ethan", "Coen", 4 },
                    { 4, "Enis Bešlagić is a Bosnian actor. In the 2000s, he starred in several films such as Fuse, Summer in the Golden Valley, Ivko's Feast, Ram za sliku moje domovine and All for Free.", new DateTime(1984, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3902), 1, "Enis", "Beslagic", 3 },
                    { 3, "Scarlett Ingrid Johansson is a Danish-American actress and singer. The world's highest-paid actress since 2018, she has made multiple appearances in the Forbes Celebrity 100.", new DateTime(1988, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3860), 4, "Scarlett", "Johansson", 3 },
                    { 2, "Edward Thomas Hardy CBE is an English actor and producer. After studying acting at the Drama Centre London, he made his film debut in Ridley Scott's Black Hawk Down.", new DateTime(1991, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3754), 5, "Tom", "Hardy", 3 },
                    { 1, "Thomas Cruise Mapother IV, better known by the stage name Tom Cruise, is an American actor and producer. ", new DateTime(1980, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(2408), 6, "Tom", "Cruise", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProdukcijskaKuca",
                columns: new[] { "Id", "GradId", "Naziv" },
                values: new object[,]
                {
                    { 1, 4, "FIST" },
                    { 2, 1, "Dinovizija" }
                });

            migrationBuilder.InsertData(
                table: "FilmGlumci",
                columns: new[] { "FilmId", "GlumacId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 8, 2 },
                    { 10, 2 },
                    { 2, 2 },
                    { 2, 1 },
                    { 14, 1 },
                    { 14, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 8, 1 },
                    { 7, 2 },
                    { 18, 1 },
                    { 5, 2 },
                    { 12, 2 },
                    { 12, 1 },
                    { 17, 1 },
                    { 9, 1 },
                    { 9, 2 },
                    { 15, 1 },
                    { 7, 1 },
                    { 15, 2 },
                    { 17, 2 },
                    { 16, 2 },
                    { 1, 2 },
                    { 13, 2 },
                    { 6, 2 },
                    { 6, 1 },
                    { 16, 1 },
                    { 19, 1 },
                    { 19, 2 },
                    { 20, 1 },
                    { 20, 2 },
                    { 10, 1 },
                    { 11, 2 },
                    { 11, 1 },
                    { 4, 2 },
                    { 4, 1 },
                    { 18, 2 },
                    { 13, 1 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "FilmProdukcijskeKuce",
                columns: new[] { "FilmId", "ProdukcijskaKucaId" },
                values: new object[,]
                {
                    { 10, 1 },
                    { 17, 2 },
                    { 3, 2 },
                    { 4, 1 },
                    { 13, 2 },
                    { 8, 1 },
                    { 7, 2 },
                    { 9, 2 },
                    { 20, 1 },
                    { 1, 2 },
                    { 19, 2 },
                    { 6, 1 },
                    { 11, 2 },
                    { 5, 2 },
                    { 12, 1 },
                    { 16, 1 },
                    { 14, 1 },
                    { 2, 1 },
                    { 15, 2 },
                    { 18, 1 }
                });

            migrationBuilder.InsertData(
                table: "FilmScenaristi",
                columns: new[] { "FilmId", "ScenaristId" },
                values: new object[,]
                {
                    { 14, 6 },
                    { 14, 5 },
                    { 4, 5 },
                    { 5, 6 },
                    { 9, 5 },
                    { 19, 6 },
                    { 9, 6 },
                    { 5, 5 },
                    { 18, 5 },
                    { 19, 5 },
                    { 4, 6 },
                    { 17, 5 },
                    { 13, 5 },
                    { 20, 6 },
                    { 1, 6 },
                    { 1, 5 },
                    { 6, 6 },
                    { 6, 5 },
                    { 11, 6 },
                    { 11, 5 },
                    { 16, 6 },
                    { 16, 5 },
                    { 15, 5 },
                    { 2, 6 },
                    { 2, 5 },
                    { 15, 6 },
                    { 7, 6 },
                    { 7, 5 },
                    { 12, 6 },
                    { 12, 5 },
                    { 17, 6 },
                    { 3, 6 },
                    { 3, 5 },
                    { 10, 5 },
                    { 8, 6 },
                    { 20, 5 },
                    { 10, 6 },
                    { 13, 6 },
                    { 18, 6 },
                    { 8, 5 }
                });

            migrationBuilder.InsertData(
                table: "KorisnikPaket",
                columns: new[] { "Id", "KorisnikId", "PaketId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 2 },
                    { 3, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ocijena",
                columns: new[] { "Id", "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[,]
                {
                    { 7, 3, 14, 3 },
                    { 3, 4, 6, 2 },
                    { 8, 4, 16, 4 },
                    { 1, 2, 2, 3 },
                    { 6, 2, 12, 2 },
                    { 5, 1, 10, 4 },
                    { 10, 1, 20, 3 },
                    { 4, 5, 8, 3 },
                    { 9, 5, 18, 2 },
                    { 2, 3, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Prijava",
                columns: new[] { "Id", "Email", "FilmId", "Opis", "PrijavioId", "Rijeseno", "Telefon", "VlasnikAutPrava" },
                values: new object[,]
                {
                    { 2, "autor2@mail.com", 5, "Prekrsio autorska prava...", 3, true, "0601445678", "Dinovizija" },
                    { 1, "autor@mail.com", 3, "Prekrsio autorska prava", 2, false, "0602345678", "Dinovizija" }
                });

            migrationBuilder.InsertData(
                table: "Projekcija",
                columns: new[] { "Id", "CijenaUlaznice", "DatumProjekcije", "DvoranaId", "FilmId", "Opis" },
                values: new object[,]
                {
                    { 5, 20.0, new DateTime(2020, 12, 30, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7386), 3, 10, "Projekcija filma 10" },
                    { 7, 26.0, new DateTime(2021, 1, 1, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7536), 2, 14, "Projekcija filma 14" },
                    { 1, 8.0, new DateTime(2020, 12, 26, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(1732), 2, 2, "Projekcija filma 2" },
                    { 4, 17.0, new DateTime(2020, 12, 29, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7313), 2, 8, "Projekcija filma 8" },
                    { 3, 14.0, new DateTime(2020, 12, 28, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7237), 1, 6, "Projekcija filma 6" },
                    { 2, 11.0, new DateTime(2020, 12, 27, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7028), 3, 4, "Projekcija filma 4" },
                    { 6, 23.0, new DateTime(2020, 12, 31, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7464), 1, 12, "Projekcija filma 12" }
                });

            migrationBuilder.InsertData(
                table: "ProjekcijaDvorana",
                columns: new[] { "ProjekcijaId", "DvoranaId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 1, 2 },
                    { 6, 1 },
                    { 4, 2 },
                    { 2, 3 },
                    { 7, 2 },
                    { 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Rezervacija",
                columns: new[] { "Id", "DatumKreirnja", "KupacId", "ProjekcijaId", "SjedisteKolona", "SjedisteRed" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 23, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(1806), 4, 3, 1, 1 },
                    { 8, new DateTime(2020, 12, 16, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3259), 2, 3, 5, 5 },
                    { 6, new DateTime(2020, 12, 18, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3178), 3, 1, 4, 4 },
                    { 4, new DateTime(2020, 12, 20, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3094), 4, 6, 3, 3 },
                    { 2, new DateTime(2020, 12, 22, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(2975), 2, 4, 2, 2 },
                    { 9, new DateTime(2020, 12, 15, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3297), 3, 4, 5, 5 },
                    { 7, new DateTime(2020, 12, 17, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3217), 4, 2, 4, 4 },
                    { 5, new DateTime(2020, 12, 19, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3135), 2, 7, 3, 3 },
                    { 3, new DateTime(2020, 12, 21, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3056), 3, 5, 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGlumci",
                keyColumns: new[] { "FilmId", "GlumacId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProdukcijskeKuce",
                keyColumns: new[] { "FilmId", "ProdukcijskaKucaId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "FilmScenaristi",
                keyColumns: new[] { "FilmId", "ScenaristId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KorisnikPaket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KorisnikPaket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KorisnikPaket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prijava",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prijava",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProjekcijaDvorana",
                keyColumns: new[] { "ProjekcijaId", "DvoranaId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProdukcijskaKuca",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProdukcijskaKuca",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tip",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tip",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tip",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DvoranaId = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Dvorana_DvoranaId",
                        column: x => x.DvoranaId,
                        principalTable: "Dvorana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_DvoranaId",
                table: "Zaposlenik",
                column: "DvoranaId");
        }
    }
}
