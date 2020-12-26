using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.API.Migrations
{
    public partial class DBSeed_final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(134), new DateTime(1995, 12, 25, 18, 35, 11, 774, DateTimeKind.Local).AddTicks(6587), "rhU9y15krz72oDSAaAeYiu80a3c=", "zsoXMab3gROO2GpJdRxC4A==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1811), new DateTime(1997, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1722), "rhU9y15krz72oDSAaAeYiu80a3c=", "zsoXMab3gROO2GpJdRxC4A==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1889), new DateTime(1997, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1877), "rhU9y15krz72oDSAaAeYiu80a3c=", "zsoXMab3gROO2GpJdRxC4A==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1951), new DateTime(1997, 12, 25, 18, 35, 11, 775, DateTimeKind.Local).AddTicks(1940), "rhU9y15krz72oDSAaAeYiu80a3c=", "zsoXMab3gROO2GpJdRxC4A==" });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FilmId", "KomentatorId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 8, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 1, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FilmId", "KomentatorId" },
                values: new object[] { 10, 1 });

            migrationBuilder.InsertData(
                table: "Ocijena",
                columns: new[] { "Id", "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[,]
                {
                    { 18, 1, 18, 1 },
                    { 17, 1, 17, 1 },
                    { 16, 1, 16, 1 },
                    { 15, 1, 15, 1 },
                    { 14, 1, 14, 1 },
                    { 13, 1, 13, 1 },
                    { 12, 1, 12, 1 },
                    { 11, 1, 11, 1 },
                    { 19, 1, 19, 1 },
                    { 20, 1, 20, 1 }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2020, 12, 26, 1, 30, 56, 267, DateTimeKind.Local).AddTicks(13), new DateTime(2020, 12, 25, 17, 30, 56, 262, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2020, 12, 26, 4, 30, 56, 267, DateTimeKind.Local).AddTicks(4434), new DateTime(2020, 12, 25, 20, 30, 56, 267, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Dvorana",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Kraj_RadnogVremena", "Pocetak_RadnogVremena" },
                values: new object[] { new DateTime(2020, 12, 26, 7, 30, 56, 267, DateTimeKind.Local).AddTicks(4574), new DateTime(2020, 12, 25, 23, 30, 56, 267, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 10,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 11,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 12,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 13,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 14,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 15,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 16,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 17,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 18,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 19,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 20,
                column: "DatumIzlaska",
                value: new DateTime(2013, 12, 25, 17, 30, 56, 270, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(2662), new DateTime(1995, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(7959), "", "" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4340), new DateTime(1997, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4258), "", "" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4420), new DateTime(1997, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4412), "", "" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2020, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4473), new DateTime(1997, 12, 25, 17, 30, 56, 269, DateTimeKind.Local).AddTicks(4465), "", "" });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 4, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 5, 8, 3 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FilmId", "KomentatorId" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 2, 12, 2 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 3, 14, 3 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 4, 16, 4 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataOcijena", "FilmId", "KomentatorId" },
                values: new object[] { 5, 18, 2 });

            migrationBuilder.UpdateData(
                table: "Ocijena",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FilmId", "KomentatorId" },
                values: new object[] { 20, 3 });

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1980, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1991, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1988, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(1984, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumRodjenja",
                value: new DateTime(1986, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumRodjenja",
                value: new DateTime(1982, 12, 25, 17, 30, 56, 268, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 11, 17, 30, 56, 272, DateTimeKind.Local).AddTicks(9533), new DateTime(2020, 12, 20, 17, 30, 56, 273, DateTimeKind.Local).AddTicks(1983), 4 });

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 13, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1249), new DateTime(2020, 12, 15, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1328), 3 });

            migrationBuilder.UpdateData(
                table: "Paket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumIsteka", "DatumKreiranja", "MaxOcijena" },
                values: new object[] { new DateTime(2021, 1, 15, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1500), new DateTime(2020, 12, 10, 17, 30, 56, 274, DateTimeKind.Local).AddTicks(1511), 5 });

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 26, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 27, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 28, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 29, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 30, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumProjekcije",
                value: new DateTime(2020, 12, 31, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Projekcija",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumProjekcije",
                value: new DateTime(2021, 1, 1, 17, 30, 56, 276, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 23, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 22, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 21, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 20, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 19, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 18, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 7,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 17, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 8,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 16, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "Id",
                keyValue: 9,
                column: "DatumKreirnja",
                value: new DateTime(2020, 12, 15, 17, 30, 56, 277, DateTimeKind.Local).AddTicks(3297));
        }
    }
}
