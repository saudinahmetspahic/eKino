using eKino.API.Database;
using eKino.Model.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.EF
{
    public partial class MojContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grad>().HasData(new API.Database.Grad { Id = 1, Naziv = "Sarajevo" });
            modelBuilder.Entity<Grad>().HasData(new API.Database.Grad { Id = 2, Naziv = "Zenica" });
            modelBuilder.Entity<Grad>().HasData(new API.Database.Grad { Id = 3, Naziv = "Mostar" });
            modelBuilder.Entity<Grad>().HasData(new API.Database.Grad { Id = 4, Naziv = "Berlin" });
            modelBuilder.Entity<Grad>().HasData(new API.Database.Grad { Id = 5, Naziv = "London" });
            modelBuilder.Entity<Grad>().HasData(new API.Database.Grad { Id = 6, Naziv = "New York" });
            for (int i = 0; i < 3; i++)
            {
                modelBuilder.Entity<Dvorana>().HasData(new API.Database.Dvorana
                {
                    Id = i + 1,
                    Pocetak_RadnogVremena = DateTime.Now.AddHours(i + (i * 2)),
                    Kraj_RadnogVremena = DateTime.Now.AddHours(i + (i * 2) + 8),
                    BrojRedova = 4 + i,
                    BrojKolona = 8 + i,
                    GradId = i + 1,
                    Naziv = "Dvorana " + (i + 1).ToString()
                });
            }

            modelBuilder.Entity<Uloga>().HasData(new API.Database.Uloga { Id = 1, NazivUloge = "Admin" });
            modelBuilder.Entity<Uloga>().HasData(new API.Database.Uloga { Id = 2, NazivUloge = "User" });
            modelBuilder.Entity<Uloga>().HasData(new API.Database.Uloga { Id = 3, NazivUloge = "Glumac" });
            modelBuilder.Entity<Uloga>().HasData(new API.Database.Uloga { Id = 4, NazivUloge = "Scenarista" });

            modelBuilder.Entity<Osoba>().HasData(new API.Database.Osoba { Id = 1, GradId = 6, Ime = "Tom", Prezime = "Cruise", UlogaId = 3, Biografija = "Thomas Cruise Mapother IV, better known by the stage name Tom Cruise, is an American actor and producer. ", DatumRodjenja = DateTime.Now.AddYears(-40) });
            modelBuilder.Entity<Osoba>().HasData(new API.Database.Osoba { Id = 2, GradId = 5, Ime = "Tom", Prezime = "Hardy", UlogaId = 3, Biografija = "Edward Thomas Hardy CBE is an English actor and producer. After studying acting at the Drama Centre London, he made his film debut in Ridley Scott's Black Hawk Down.", DatumRodjenja = DateTime.Now.AddYears(-29) });
            modelBuilder.Entity<Osoba>().HasData(new API.Database.Osoba { Id = 3, GradId = 4, Ime = "Scarlett", Prezime = "Johansson", UlogaId = 3, Biografija = "Scarlett Ingrid Johansson is a Danish-American actress and singer. The world's highest-paid actress since 2018, she has made multiple appearances in the Forbes Celebrity 100.", DatumRodjenja = DateTime.Now.AddYears(-32) });
            modelBuilder.Entity<Osoba>().HasData(new API.Database.Osoba { Id = 4, GradId = 1, Ime = "Enis", Prezime = "Beslagic", UlogaId = 3, Biografija = "Enis Bešlagić is a Bosnian actor. In the 2000s, he starred in several films such as Fuse, Summer in the Golden Valley, Ivko's Feast, Ram za sliku moje domovine and All for Free.", DatumRodjenja = DateTime.Now.AddYears(-36) });
            modelBuilder.Entity<Osoba>().HasData(new API.Database.Osoba { Id = 5, GradId = 6, Ime = "Ethan", Prezime = "Coen", UlogaId = 4, Biografija = "Joel Coen and Ethan Coen, collectively referred to as the Coen Brothers, are American film directors, producers, screenwriters, and editors. Their films span many genres and styles, which they frequently subvert or parody.", DatumRodjenja = DateTime.Now.AddYears(-34) });
            modelBuilder.Entity<Osoba>().HasData(new API.Database.Osoba { Id = 6, GradId = 4, Ime = "Christopher", Prezime = "Nolan", UlogaId = 4, Biografija = "Christopher Edward Nolan, (born 30 July 1970) is an English-American film director, screenwriter, and producer, who is known for making personal, distinctive films within the Hollywood mainstream.", DatumRodjenja = DateTime.Now.AddYears(-38) });


            // pass: "password"
            modelBuilder.Entity<Korisnik>().HasData(new API.Database.Korisnik { Id = 1, GradId = 2, Ime = "Admin", Prezime = "Admin", UlogaId = 1, DatumRodjenja = DateTime.Now.AddYears(-25), Email = "admin@mail.com", LozinkaSalt = "zsoXMab3gROO2GpJdRxC4A==", LozinkaHash = "rhU9y15krz72oDSAaAeYiu80a3c=", SlanjeEmaila = true, DatumRegistracije = DateTime.Now });
            modelBuilder.Entity<Korisnik>().HasData(new API.Database.Korisnik { Id = 2, GradId = 4, Ime = "Korisnik", Prezime = "1", UlogaId = 2, DatumRodjenja = DateTime.Now.AddYears(-23), Email = "user1@mail.com", LozinkaSalt = "zsoXMab3gROO2GpJdRxC4A==", LozinkaHash = "rhU9y15krz72oDSAaAeYiu80a3c=", SlanjeEmaila = true, DatumRegistracije = DateTime.Now });
            modelBuilder.Entity<Korisnik>().HasData(new API.Database.Korisnik { Id = 3, GradId = 3, Ime = "Korisnik", Prezime = "2", UlogaId = 2, DatumRodjenja = DateTime.Now.AddYears(-23), Email = "user2@mail.com", LozinkaSalt = "zsoXMab3gROO2GpJdRxC4A==", LozinkaHash = "rhU9y15krz72oDSAaAeYiu80a3c=", SlanjeEmaila = true, DatumRegistracije = DateTime.Now });
            modelBuilder.Entity<Korisnik>().HasData(new API.Database.Korisnik { Id = 4, GradId = 2, Ime = "Korisnik", Prezime = "3", UlogaId = 2, DatumRodjenja = DateTime.Now.AddYears(-23), Email = "user3@mail.com", LozinkaSalt = "zsoXMab3gROO2GpJdRxC4A==", LozinkaHash = "rhU9y15krz72oDSAaAeYiu80a3c=", SlanjeEmaila = true, DatumRegistracije = DateTime.Now });

            var link = "https://ia803206.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4"; // pawnshop

            modelBuilder.Entity<Tip>().HasData(new API.Database.Tip { Id = 1, NazivTipa = "Igrani" });
            modelBuilder.Entity<Tip>().HasData(new API.Database.Tip { Id = 2, NazivTipa = "Animirani" });
            modelBuilder.Entity<Tip>().HasData(new API.Database.Tip { Id = 3, NazivTipa = "Dokumentarac" });

            modelBuilder.Entity<Zanr>().HasData(new API.Database.Zanr { Id = 1, NazivZanra = "Akcija" });
            modelBuilder.Entity<Zanr>().HasData(new API.Database.Zanr { Id = 2, NazivZanra = "Drama" });
            modelBuilder.Entity<Zanr>().HasData(new API.Database.Zanr { Id = 3, NazivZanra = "Komendija" });
            modelBuilder.Entity<Zanr>().HasData(new API.Database.Zanr { Id = 4, NazivZanra = "Horor" });
            modelBuilder.Entity<Zanr>().HasData(new API.Database.Zanr { Id = 5, NazivZanra = "Sci-Fi" });

            // slika moze pravit problem
            var slika = ImageHelper.GetImage("imgInitial.jpg");

            for (int i = 0; i < 20; i++)
            {
                modelBuilder.Entity<Film>().HasData(new API.Database.Film
                {
                    Id = i + 1,
                    Naziv = "Film " + (i + 1),
                    Opis = "Kratki opis filma " + (i + 1) + ", opis radnje i glumaca u filmu. Prikazuje se prilikom ispisa detalja o filmu.",
                    Link = link,
                    TipId = (i % 3) + 1,
                    ZanrId = (i % 5) + 1,
                    DatumIzlaska = DateTime.Now.AddYears(-7),
                    Slika = slika
                });

                modelBuilder.Entity<Ocijena>().HasData(new API.Database.Ocijena
                {
                    Id = i + 1,
                    DataOcijena = 1,
                    FilmId = i + 1,
                    KomentatorId = 1,
                });
            }

            modelBuilder.Entity<ProdukcijskaKuca>().HasData(new API.Database.ProdukcijskaKuca { Id = 1, GradId = 4, Naziv = "FIST" });
            modelBuilder.Entity<ProdukcijskaKuca>().HasData(new API.Database.ProdukcijskaKuca { Id = 2, GradId = 1, Naziv = "Dinovizija" });

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    modelBuilder.Entity<FilmGlumci>().HasData(new API.Database.FilmGlumci
                    {
                        GlumacId = (j % 2) + 1,
                        FilmId = i
                    });
                }

                for (int j = 1; j <= 2; j++)
                {
                    modelBuilder.Entity<FilmScenaristi>().HasData(new API.Database.FilmScenaristi
                    {
                        ScenaristId = (j % 2) + 5,
                        FilmId = i
                    });
                }

                modelBuilder.Entity<FilmProdukcijskeKuce>().HasData(new API.Database.FilmProdukcijskeKuce
                {
                    ProdukcijskaKucaId = (i % 2) + 1,
                    FilmId = i
                });
            }

            for (int i = 1; i <= 3; i++)
            {
                modelBuilder.Entity<Paket>().HasData(new API.Database.Paket
                {
                    Id = i,
                    Cijena = i * 10 + Math.Pow(i, 2),
                    DatumIsteka = DateTime.Now.AddDays(15 + (2 * i)),
                    DatumKreiranja = DateTime.Now.AddDays(-5 * i),
                    MaxOcijena = (new Random().Next() % 5) + 1,
                    Opis = "Paket " + i
                });
            }

            modelBuilder.Entity<KorisnikPaket>().HasData(new API.Database.KorisnikPaket { Id = 1, KorisnikId = 2, PaketId = 1 });
            modelBuilder.Entity<KorisnikPaket>().HasData(new API.Database.KorisnikPaket { Id = 2, KorisnikId = 3, PaketId = 2 });
            modelBuilder.Entity<KorisnikPaket>().HasData(new API.Database.KorisnikPaket { Id = 3, KorisnikId = 4, PaketId = 3 });



            modelBuilder.Entity<Prijava>().HasData(new API.Database.Prijava
            {
                Id = 1,
                FilmId = 3,
                Email = "autor@mail.com",
                Opis = "Prekrsio autorska prava",
                PrijavioId = 2,
                Rijeseno = false,
                Telefon = "0602345678",
                VlasnikAutPrava = "Dinovizija"
            });
            modelBuilder.Entity<Prijava>().HasData(new API.Database.Prijava
            {
                Id = 2,
                FilmId = 5,
                Email = "autor2@mail.com",
                Opis = "Prekrsio autorska prava...",
                PrijavioId = 3,
                Rijeseno = true,
                Telefon = "0601445678",
                VlasnikAutPrava = "Dinovizija"
            });

            for (int i = 1; i <= 7; i++)
            {
                modelBuilder.Entity<Projekcija>().HasData(new API.Database.Projekcija
                {
                    Id = i,
                    CijenaUlaznice = i * 3 + 5,
                    DatumProjekcije = DateTime.Now.AddDays(i),
                    DvoranaId = (i % 3) + 1,
                    FilmId = i + i,
                    Opis = "Projekcija filma " + (i + i).ToString()
                });

                modelBuilder.Entity<ProjekcijaDvorana>().HasData(new API.Database.ProjekcijaDvorana
                {
                    DvoranaId = (i % 3) + 1,
                    ProjekcijaId = i
                });
            }

            for (int i = 2; i <= 10; i++)
            {
                modelBuilder.Entity<Rezervacija>().HasData(new API.Database.Rezervacija
                {
                    Id = i - 1,
                    ProjekcijaId = (i % 7) + 1,
                    KupacId = (i % 3) + 2,
                    SjedisteRed = (i + 1) / 2,
                    SjedisteKolona = (i + 1) / 2,
                    DatumKreirnja = DateTime.Now.AddDays(-i)
                });

            }

        }

    }
}
