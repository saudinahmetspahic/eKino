using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class M13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2021, 1, 4, 23, 44, 36, 6, DateTimeKind.Local).AddTicks(4221), new DateTime(2021, 1, 4, 15, 44, 35, 996, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2021, 1, 5, 2, 44, 36, 7, DateTimeKind.Local).AddTicks(741), new DateTime(2021, 1, 4, 18, 44, 36, 7, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2021, 1, 5, 5, 44, 36, 7, DateTimeKind.Local).AddTicks(933), new DateTime(2021, 1, 4, 21, 44, 36, 7, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 11, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 10,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 11,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 12,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 13,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 14,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 15,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 16,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 12, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 17,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 13, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 18,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 13, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 19,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 13, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 20,
                column: "DatumIzlaska",
                value: new DateTime(2014, 1, 4, 15, 44, 36, 13, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2021, 1, 4, 15, 44, 36, 9, DateTimeKind.Local).AddTicks(9073), new DateTime(1996, 1, 4, 15, 44, 36, 9, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2021, 1, 4, 15, 44, 36, 10, DateTimeKind.Local).AddTicks(1837), new DateTime(1998, 1, 4, 15, 44, 36, 10, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2021, 1, 4, 15, 44, 36, 10, DateTimeKind.Local).AddTicks(1969), new DateTime(1998, 1, 4, 15, 44, 36, 10, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2021, 1, 4, 15, 44, 36, 10, DateTimeKind.Local).AddTicks(2050), new DateTime(1998, 1, 4, 15, 44, 36, 10, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1981, 1, 4, 15, 44, 36, 8, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1992, 1, 4, 15, 44, 36, 8, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1989, 1, 4, 15, 44, 36, 8, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(1985, 1, 4, 15, 44, 36, 8, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumRodjenja",
                value: new DateTime(1987, 1, 4, 15, 44, 36, 8, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumRodjenja",
                value: new DateTime(1983, 1, 4, 15, 44, 36, 8, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 21, 15, 44, 36, 16, DateTimeKind.Local).AddTicks(555), new DateTime(2020, 12, 30, 15, 44, 36, 16, DateTimeKind.Local).AddTicks(3986), 4 });

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 23, 15, 44, 36, 17, DateTimeKind.Local).AddTicks(44), new DateTime(2020, 12, 25, 15, 44, 36, 17, DateTimeKind.Local).AddTicks(100), 2 });

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 25, 15, 44, 36, 17, DateTimeKind.Local).AddTicks(332), new DateTime(2020, 12, 20, 15, 44, 36, 17, DateTimeKind.Local).AddTicks(347), 4 });

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 5, 15, 44, 36, 20, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 6, 15, 44, 36, 21, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 7, 15, 44, 36, 21, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 8, 15, 44, 36, 21, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 9, 15, 44, 36, 21, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 10, 15, 44, 36, 21, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 11, 15, 44, 36, 21, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreirnja",
                value: new DateTime(2021, 1, 2, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreirnja",
                value: new DateTime(2021, 1, 1, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 31, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 30, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 29, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 28, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 27, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 26, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 25, 15, 44, 36, 22, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Uloga",
                keyColumn: "Id",
                keyValue: 2,
                column: "NazivUloge",
                value: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2020, 12, 26, 2, 35, 11, 772, DateTimeKind.Local).AddTicks(5631), new DateTime(2020, 12, 25, 18, 35, 11, 769, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2020, 12, 26, 5, 35, 11, 772, DateTimeKind.Local).AddTicks(9370), new DateTime(2020, 12, 25, 21, 35, 11, 772, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2020, 12, 26, 8, 35, 11, 772, DateTimeKind.Local).AddTicks(9508), new DateTime(2020, 12, 26, 0, 35, 11, 772, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 776, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 10,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 11,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 12,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 13,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 14,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 15,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 16,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 17,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 18,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 19,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 20,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 18, 35, 11, 777, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(134), new DateTime(1995, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1811), new DateTime(1997, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1889), new DateTime(1997, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "DatumRodjenja" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1951), new DateTime(1997, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1980, 12, 25, 18, 35, 11, 773, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1991, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1988, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(1984, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumRodjenja",
                value: new DateTime(1986, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumRodjenja",
                value: new DateTime(1982, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 11, 18, 35, 11, 779, DateTimeKind.Local).AddTicks(3035), new DateTime(2020, 12, 20, 18, 35, 11, 779, DateTimeKind.Local).AddTicks(4643), 1 });

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 13, 18, 35, 11, 779, DateTimeKind.Local).AddTicks(7424), new DateTime(2020, 12, 15, 18, 35, 11, 779, DateTimeKind.Local).AddTicks(7454), 5 });

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 15, 18, 35, 11, 779, DateTimeKind.Local).AddTicks(7630), new DateTime(2020, 12, 10, 18, 35, 11, 779, DateTimeKind.Local).AddTicks(7636), 2 });

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 26, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 27, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 28, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 29, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 30, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 31, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 1, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 23, 18, 35, 11, 781, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 22, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 21, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 20, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 19, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 18, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 17, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 16, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 15, 18, 35, 11, 782, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Uloga",
                keyColumn: "Id",
                keyValue: 2,
                column: "NazivUloge",
                value: "Guest");
        }
    }
}
