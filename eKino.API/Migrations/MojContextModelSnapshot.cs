﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eKino.API.EF;

namespace eKino.API.Migrations
{
    [DbContext(typeof(MojContext))]
    partial class MojContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eKino.API.Database.Dvorana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("BrojSjedista")
                        .HasColumnType("smallint");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Kraj_RadnogVremena")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Pocetak_RadnogVremena")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Dvorana");
                });

            modelBuilder.Entity("eKino.API.Database.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzlaska")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipId")
                        .HasColumnType("int");

                    b.Property<int>("ZanrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipId");

                    b.HasIndex("ZanrId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("eKino.API.Database.FilmGlumci", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("GlumacId")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "GlumacId");

                    b.HasIndex("GlumacId");

                    b.ToTable("FilmGlumci");
                });

            modelBuilder.Entity("eKino.API.Database.FilmProdukcijskeKuce", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("ProdukcijskaKucaId")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "ProdukcijskaKucaId");

                    b.HasIndex("ProdukcijskaKucaId");

                    b.ToTable("FilmProdukcijskeKuce");
                });

            modelBuilder.Entity("eKino.API.Database.FilmScenaristi", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("ScenaristId")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "ScenaristId");

                    b.HasIndex("ScenaristId");

                    b.ToTable("FilmScenaristi");
                });

            modelBuilder.Entity("eKino.API.Database.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("eKino.API.Database.Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("KomentatorId")
                        .HasColumnType("int");

                    b.Property<string>("SadrzajKomentara")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("KomentatorId");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("eKino.API.Database.KorisnikPaket", b =>
                {
                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("PaketId")
                        .HasColumnType("int");

                    b.HasKey("KorisnikId", "PaketId");

                    b.HasIndex("PaketId");

                    b.ToTable("OsobaPaket");
                });

            modelBuilder.Entity("eKino.API.Database.Ocijena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KomentatorId")
                        .HasColumnType("int");

                    b.Property<int>("Ocijena1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("KomentatorId");

                    b.ToTable("Ocijena");
                });

            modelBuilder.Entity("eKino.API.Database.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Osoba");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Osoba");
                });

            modelBuilder.Entity("eKino.API.Database.Paket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Cijena")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxOcijena")
                        .HasColumnType("int");

                    b.Property<int>("MinOcijena")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paket");
                });

            modelBuilder.Entity("eKino.API.Database.ProdukcijskaKuca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("ProdukcijskaKuca");
                });

            modelBuilder.Entity("eKino.API.Database.Projekcija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CijenaUlaznice")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumProjekcije")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("Projekcija");
                });

            modelBuilder.Entity("eKino.API.Database.ProjekcijaDvorana", b =>
                {
                    b.Property<int>("ProjekcijaId")
                        .HasColumnType("int");

                    b.Property<int>("DvoranaId")
                        .HasColumnType("int");

                    b.HasKey("ProjekcijaId", "DvoranaId");

                    b.HasIndex("DvoranaId");

                    b.ToTable("ProjekcijaDvorana");
                });

            modelBuilder.Entity("eKino.API.Database.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKreirnja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KupacId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjekcijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("ProjekcijaId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("eKino.API.Database.Tip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivTipa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tip");
                });

            modelBuilder.Entity("eKino.API.Database.Zanr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivZanra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("eKino.API.Database.Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("DvoranaId")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DvoranaId");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("eKino.API.Database.KorisnikController", b =>
                {
                    b.HasBaseType("eKino.API.Database.Osoba");

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasDiscriminator().HasValue("KorisnikController");
                });

            modelBuilder.Entity("eKino.API.Database.Dvorana", b =>
                {
                    b.HasOne("eKino.API.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.Film", b =>
                {
                    b.HasOne("eKino.API.Database.Tip", "Tip")
                        .WithMany()
                        .HasForeignKey("TipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.Zanr", "Zanr")
                        .WithMany()
                        .HasForeignKey("ZanrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.FilmGlumci", b =>
                {
                    b.HasOne("eKino.API.Database.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.Osoba", "Glumac")
                        .WithMany()
                        .HasForeignKey("GlumacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.FilmProdukcijskeKuce", b =>
                {
                    b.HasOne("eKino.API.Database.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.ProdukcijskaKuca", "ProdukcijskaKuca")
                        .WithMany()
                        .HasForeignKey("ProdukcijskaKucaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.FilmScenaristi", b =>
                {
                    b.HasOne("eKino.API.Database.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.Osoba", "Scenarist")
                        .WithMany()
                        .HasForeignKey("ScenaristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.Komentar", b =>
                {
                    b.HasOne("eKino.API.Database.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.KorisnikController", "Komentator")
                        .WithMany()
                        .HasForeignKey("KomentatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.KorisnikPaket", b =>
                {
                    b.HasOne("eKino.API.Database.KorisnikController", "KorisnikController")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.Paket", "Paket")
                        .WithMany()
                        .HasForeignKey("PaketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.Ocijena", b =>
                {
                    b.HasOne("eKino.API.Database.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.KorisnikController", "Komentator")
                        .WithMany()
                        .HasForeignKey("KomentatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.Osoba", b =>
                {
                    b.HasOne("eKino.API.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId");
                });

            modelBuilder.Entity("eKino.API.Database.ProdukcijskaKuca", b =>
                {
                    b.HasOne("eKino.API.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId");
                });

            modelBuilder.Entity("eKino.API.Database.Projekcija", b =>
                {
                    b.HasOne("eKino.API.Database.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.ProjekcijaDvorana", b =>
                {
                    b.HasOne("eKino.API.Database.Dvorana", "Dvorana")
                        .WithMany()
                        .HasForeignKey("DvoranaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eKino.API.Database.Projekcija", "Projekcija")
                        .WithMany()
                        .HasForeignKey("ProjekcijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eKino.API.Database.Rezervacija", b =>
                {
                    b.HasOne("eKino.API.Database.KorisnikController", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId");

                    b.HasOne("eKino.API.Database.Projekcija", "Projekcija")
                        .WithMany()
                        .HasForeignKey("ProjekcijaId");
                });

            modelBuilder.Entity("eKino.API.Database.Zaposlenik", b =>
                {
                    b.HasOne("eKino.API.Database.Dvorana", "Dvorana")
                        .WithMany()
                        .HasForeignKey("DvoranaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
