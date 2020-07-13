using eKino.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.EF
{
    public class MojContext : DbContext
    {
        public MojContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // kompozitni kljuc
            modelBuilder.Entity<FilmGlumci>()
                .HasKey(c => new { c.FilmId, c.GlumacId });

            // kompozitni kljuc
            modelBuilder.Entity<FilmProdukcijskeKuce>()
                .HasKey(c => new { c.FilmId, c.ProdukcijskaKucaId });

            // kompozitni kljuc
            modelBuilder.Entity<FilmScenaristi>()
                .HasKey(c => new { c.FilmId, c.ScenaristId });

            // kompozitni kljuc
            modelBuilder.Entity<KorisnikPaket>()
                .HasKey(c => new { c.KorisnikId, c.PaketId });

            // kompozitni kljuc
            modelBuilder.Entity<ProjekcijaDvorana>()
                .HasKey(c => new { c.ProjekcijaId, c.DvoranaId });
        }

        public DbSet<Dvorana> Dvorana { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<FilmGlumci> FilmGlumci { get; set; }
        public DbSet<FilmProdukcijskeKuce> FilmProdukcijskeKuce { get; set; }
        public DbSet<FilmScenaristi> FilmScenaristi { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Komentar> Komentar { get; set; }
        public DbSet<Ocijena> Ocijena { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<KorisnikPaket> OsobaPaket { get; set; }
        public DbSet<Paket> Paket { get; set; }
        public DbSet<ProdukcijskaKuca> ProdukcijskaKuca { get; set; }
        public DbSet<Projekcija> Projekcija { get; set; }
        public DbSet<ProjekcijaDvorana> ProjekcijaDvorana { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<Tip> Tip { get; set; }
        public DbSet<Zanr> Zanr { get; set; }
        public DbSet<Zaposlenik> Zaposlenik { get; set; }


    }
}
