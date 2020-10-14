using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public DateTime DatumKreirnja { get; set; }
        public int SjedisteRed { get; set; }
        public int SjedisteKolona { get; set; }

        [ForeignKey(nameof(ProjekcijaId))]
        public int? ProjekcijaId { get; set; }
        public virtual Projekcija Projekcija { get; set; }

        [ForeignKey(nameof(KupacId))]
        public int? KupacId { get; set; }
        public virtual Korisnik Kupac { get; set; }

    }
}
