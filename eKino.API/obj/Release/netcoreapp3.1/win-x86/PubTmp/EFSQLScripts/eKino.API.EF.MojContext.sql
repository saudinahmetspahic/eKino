IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Grad] (
        [Id] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        CONSTRAINT [PK_Grad] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Paket] (
        [Id] int NOT NULL IDENTITY,
        [DatumKreiranja] datetime2 NOT NULL,
        [DatumIsteka] datetime2 NULL,
        [MinOcijena] int NOT NULL,
        [MaxOcijena] int NOT NULL,
        [Opis] nvarchar(max) NULL,
        [Cijena] float NULL,
        CONSTRAINT [PK_Paket] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Tip] (
        [Id] int NOT NULL IDENTITY,
        [NazivTipa] nvarchar(max) NULL,
        CONSTRAINT [PK_Tip] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Uloga] (
        [Id] int NOT NULL IDENTITY,
        [NazivUloge] nvarchar(max) NULL,
        CONSTRAINT [PK_Uloga] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Zanr] (
        [Id] int NOT NULL IDENTITY,
        [NazivZanra] nvarchar(max) NULL,
        CONSTRAINT [PK_Zanr] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Dvorana] (
        [Id] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [BrojSjedista] smallint NOT NULL,
        [Pocetak_RadnogVremena] datetime2 NOT NULL,
        [Kraj_RadnogVremena] datetime2 NOT NULL,
        [GradId] int NOT NULL,
        CONSTRAINT [PK_Dvorana] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Dvorana_Grad_GradId] FOREIGN KEY ([GradId]) REFERENCES [Grad] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Osoba] (
        [Id] int NOT NULL IDENTITY,
        [Ime] nvarchar(max) NULL,
        [Prezime] nvarchar(max) NULL,
        [DatumRodjenja] datetime2 NOT NULL,
        [Biografija] nvarchar(max) NULL,
        [GradId] int NULL,
        CONSTRAINT [PK_Osoba] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Osoba_Grad_GradId] FOREIGN KEY ([GradId]) REFERENCES [Grad] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [ProdukcijskaKuca] (
        [Id] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [GradId] int NULL,
        CONSTRAINT [PK_ProdukcijskaKuca] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProdukcijskaKuca_Grad_GradId] FOREIGN KEY ([GradId]) REFERENCES [Grad] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Korisnik] (
        [Id] int NOT NULL IDENTITY,
        [Ime] nvarchar(max) NULL,
        [Prezime] nvarchar(max) NULL,
        [DatumRodjenja] datetime2 NOT NULL,
        [DatumRegistracije] datetime2 NOT NULL,
        [Email] nvarchar(max) NULL,
        [LozinkaSalt] nvarchar(max) NULL,
        [LozinkaHash] nvarchar(max) NULL,
        [UlogaId] int NOT NULL,
        [GradId] int NOT NULL,
        CONSTRAINT [PK_Korisnik] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Korisnik_Grad_GradId] FOREIGN KEY ([GradId]) REFERENCES [Grad] ([Id]),
        CONSTRAINT [FK_Korisnik_Uloga_UlogaId] FOREIGN KEY ([UlogaId]) REFERENCES [Uloga] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Film] (
        [Id] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [Opis] nvarchar(max) NULL,
        [DatumIzlaska] datetime2 NOT NULL,
        [TipId] int NOT NULL,
        [ZanrId] int NOT NULL,
        CONSTRAINT [PK_Film] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Film_Tip_TipId] FOREIGN KEY ([TipId]) REFERENCES [Tip] ([Id]),
        CONSTRAINT [FK_Film_Zanr_ZanrId] FOREIGN KEY ([ZanrId]) REFERENCES [Zanr] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Zaposlenik] (
        [Id] int NOT NULL IDENTITY,
        [Ime] nvarchar(max) NULL,
        [Prezime] nvarchar(max) NULL,
        [DatumRodjenja] datetime2 NOT NULL,
        [BrojTelefona] nvarchar(max) NULL,
        [DvoranaId] int NOT NULL,
        CONSTRAINT [PK_Zaposlenik] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Zaposlenik_Dvorana_DvoranaId] FOREIGN KEY ([DvoranaId]) REFERENCES [Dvorana] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [KorisnikPaket] (
        [KorisnikId] int NOT NULL,
        [PaketId] int NOT NULL,
        CONSTRAINT [PK_KorisnikPaket] PRIMARY KEY ([KorisnikId], [PaketId]),
        CONSTRAINT [FK_KorisnikPaket_Korisnik_KorisnikId] FOREIGN KEY ([KorisnikId]) REFERENCES [Korisnik] ([Id]),
        CONSTRAINT [FK_KorisnikPaket_Paket_PaketId] FOREIGN KEY ([PaketId]) REFERENCES [Paket] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [FilmGlumciController] (
        [FilmId] int NOT NULL,
        [GlumacId] int NOT NULL,
        CONSTRAINT [PK_FilmGlumci] PRIMARY KEY ([FilmId], [GlumacId]),
        CONSTRAINT [FK_FilmGlumci_Film_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Film] ([Id]),
        CONSTRAINT [FK_FilmGlumci_Osoba_GlumacId] FOREIGN KEY ([GlumacId]) REFERENCES [Osoba] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [FilmProdukcijskeKuceService] (
        [FilmId] int NOT NULL,
        [ProdukcijskaKucaId] int NOT NULL,
        CONSTRAINT [PK_FilmProdukcijskeKuce] PRIMARY KEY ([FilmId], [ProdukcijskaKucaId]),
        CONSTRAINT [FK_FilmProdukcijskeKuce_Film_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Film] ([Id]),
        CONSTRAINT [FK_FilmProdukcijskeKuce_ProdukcijskaKuca_ProdukcijskaKucaId] FOREIGN KEY ([ProdukcijskaKucaId]) REFERENCES [ProdukcijskaKuca] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [FilmScenaristi] (
        [FilmId] int NOT NULL,
        [ScenaristId] int NOT NULL,
        CONSTRAINT [PK_FilmScenaristi] PRIMARY KEY ([FilmId], [ScenaristId]),
        CONSTRAINT [FK_FilmScenaristi_Film_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Film] ([Id]),
        CONSTRAINT [FK_FilmScenaristi_Osoba_ScenaristId] FOREIGN KEY ([ScenaristId]) REFERENCES [Osoba] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Komentar] (
        [Id] int NOT NULL IDENTITY,
        [SadrzajKomentara] nvarchar(max) NULL,
        [KomentatorId] int NOT NULL,
        [FilmId] int NOT NULL,
        CONSTRAINT [PK_Komentar] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Komentar_Film_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Film] ([Id]),
        CONSTRAINT [FK_Komentar_Korisnik_KomentatorId] FOREIGN KEY ([KomentatorId]) REFERENCES [Korisnik] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Ocijena] (
        [Id] int NOT NULL IDENTITY,
        [Ocijena1] int NOT NULL,
        [Komentar] nvarchar(max) NULL,
        [KomentatorId] int NOT NULL,
        [FilmId] int NOT NULL,
        CONSTRAINT [PK_Ocijena] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Ocijena_Film_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Film] ([Id]),
        CONSTRAINT [FK_Ocijena_Korisnik_KomentatorId] FOREIGN KEY ([KomentatorId]) REFERENCES [Korisnik] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Projekcija] (
        [Id] int NOT NULL IDENTITY,
        [CijenaUlaznice] float NOT NULL,
        [Opis] nvarchar(max) NULL,
        [DatumProjekcije] datetime2 NOT NULL,
        [FilmId] int NOT NULL,
        CONSTRAINT [PK_Projekcija] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Projekcija_Film_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Film] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [KomentarReakcija] (
        [KorisnikId] int NOT NULL,
        [KomentarId] int NOT NULL,
        [Reakcija] int NOT NULL,
        CONSTRAINT [PK_KomentarReakcija] PRIMARY KEY ([KomentarId], [KorisnikId]),
        CONSTRAINT [FK_KomentarReakcija_Komentar_KomentarId] FOREIGN KEY ([KomentarId]) REFERENCES [Komentar] ([Id]),
        CONSTRAINT [FK_KomentarReakcija_Korisnik_KorisnikId] FOREIGN KEY ([KorisnikId]) REFERENCES [Korisnik] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [ProjekcijaDvorana] (
        [ProjekcijaId] int NOT NULL,
        [DvoranaId] int NOT NULL,
        CONSTRAINT [PK_ProjekcijaDvorana] PRIMARY KEY ([ProjekcijaId], [DvoranaId]),
        CONSTRAINT [FK_ProjekcijaDvorana_Dvorana_DvoranaId] FOREIGN KEY ([DvoranaId]) REFERENCES [Dvorana] ([Id]),
        CONSTRAINT [FK_ProjekcijaDvorana_Projekcija_ProjekcijaId] FOREIGN KEY ([ProjekcijaId]) REFERENCES [Projekcija] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE TABLE [Rezervacija] (
        [Id] int NOT NULL IDENTITY,
        [DatumKreirnja] datetime2 NOT NULL,
        [ProjekcijaId] int NULL,
        [KupacId] int NULL,
        CONSTRAINT [PK_Rezervacija] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Rezervacija_Korisnik_KupacId] FOREIGN KEY ([KupacId]) REFERENCES [Korisnik] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Rezervacija_Projekcija_ProjekcijaId] FOREIGN KEY ([ProjekcijaId]) REFERENCES [Projekcija] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Dvorana_GradId] ON [Dvorana] ([GradId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Film_TipId] ON [Film] ([TipId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Film_ZanrId] ON [Film] ([ZanrId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_FilmGlumci_GlumacId] ON [FilmGlumciController] ([GlumacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_FilmProdukcijskeKuce_ProdukcijskaKucaId] ON [FilmProdukcijskeKuceService] ([ProdukcijskaKucaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_FilmScenaristi_ScenaristId] ON [FilmScenaristi] ([ScenaristId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Komentar_FilmId] ON [Komentar] ([FilmId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Komentar_KomentatorId] ON [Komentar] ([KomentatorId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_KomentarReakcija_KorisnikId] ON [KomentarReakcija] ([KorisnikId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Korisnik_GradId] ON [Korisnik] ([GradId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Korisnik_UlogaId] ON [Korisnik] ([UlogaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_KorisnikPaket_PaketId] ON [KorisnikPaket] ([PaketId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Ocijena_FilmId] ON [Ocijena] ([FilmId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Ocijena_KomentatorId] ON [Ocijena] ([KomentatorId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Osoba_GradId] ON [Osoba] ([GradId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_ProdukcijskaKuca_GradId] ON [ProdukcijskaKuca] ([GradId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Projekcija_FilmId] ON [Projekcija] ([FilmId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_ProjekcijaDvorana_DvoranaId] ON [ProjekcijaDvorana] ([DvoranaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Rezervacija_KupacId] ON [Rezervacija] ([KupacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Rezervacija_ProjekcijaId] ON [Rezervacija] ([ProjekcijaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    CREATE INDEX [IX_Zaposlenik_DvoranaId] ON [Zaposlenik] ([DvoranaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200811163145_M0')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200811163145_M0', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910123155_M1')
BEGIN
    ALTER TABLE [Film] ADD [Link] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910123155_M1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200910123155_M1', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910125728_M2')
BEGIN
    ALTER TABLE [Projekcija] ADD [DvoranaId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910125728_M2')
BEGIN
    CREATE INDEX [IX_Projekcija_DvoranaId] ON [Projekcija] ([DvoranaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910125728_M2')
BEGIN
    ALTER TABLE [Projekcija] ADD CONSTRAINT [FK_Projekcija_Dvorana_DvoranaId] FOREIGN KEY ([DvoranaId]) REFERENCES [Dvorana] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910125728_M2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200910125728_M2', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910190232_M3')
BEGIN
    ALTER TABLE [Film] ADD [Slika] varbinary(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200910190232_M3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200910190232_M3', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915111313_M4')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Ocijena]') AND [c].[name] = N'Ocijena1');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Ocijena] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Ocijena] DROP COLUMN [Ocijena1];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915111313_M4')
BEGIN
    ALTER TABLE [Ocijena] ADD [DataOcijena] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915111313_M4')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200915111313_M4', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915124408_M5')
BEGIN
    ALTER TABLE [Osoba] ADD [UlogaId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915124408_M5')
BEGIN
    CREATE INDEX [IX_Osoba_UlogaId] ON [Osoba] ([UlogaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915124408_M5')
BEGIN
    ALTER TABLE [Osoba] ADD CONSTRAINT [FK_Osoba_Uloga_UlogaId] FOREIGN KEY ([UlogaId]) REFERENCES [Uloga] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200915124408_M5')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200915124408_M5', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200924173535_M6')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Paket]') AND [c].[name] = N'MinOcijena');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Paket] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Paket] DROP COLUMN [MinOcijena];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200924173535_M6')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200924173535_M6', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200928165014_M7')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Ocijena]') AND [c].[name] = N'Komentar');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Ocijena] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Ocijena] DROP COLUMN [Komentar];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200928165014_M7')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200928165014_M7', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929123459_M8')
BEGIN
    ALTER TABLE [Rezervacija] ADD [SjedisteKolona] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929123459_M8')
BEGIN
    ALTER TABLE [Rezervacija] ADD [SjedisteRed] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929123459_M8')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200929123459_M8', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929132143_M9')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Dvorana]') AND [c].[name] = N'BrojSjedista');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Dvorana] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Dvorana] DROP COLUMN [BrojSjedista];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929132143_M9')
BEGIN
    ALTER TABLE [Dvorana] ADD [BrojKolona] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929132143_M9')
BEGIN
    ALTER TABLE [Dvorana] ADD [BrojRedova] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200929132143_M9')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200929132143_M9', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200930113806_M10')
BEGIN
    ALTER TABLE [KorisnikPaket] DROP CONSTRAINT [PK_KorisnikPaket];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200930113806_M10')
BEGIN
    ALTER TABLE [KorisnikPaket] ADD [Id] int NOT NULL IDENTITY;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200930113806_M10')
BEGIN
    ALTER TABLE [KorisnikPaket] ADD CONSTRAINT [PK_KorisnikPaket] PRIMARY KEY ([Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200930113806_M10')
BEGIN
    CREATE INDEX [IX_KorisnikPaket_KorisnikId] ON [KorisnikPaket] ([KorisnikId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200930113806_M10')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200930113806_M10', N'3.1.8');
END;

GO

