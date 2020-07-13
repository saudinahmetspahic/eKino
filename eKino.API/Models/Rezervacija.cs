using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Models
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public DateTime DatumKreirnja { get; set; }

        [ForeignKey(nameof(ProjekcijaId))]
        public int? ProjekcijaId { get; set; }
        public virtual Projekcija Projekcija { get; set; }

        [ForeignKey(nameof(KupacId))]
        public int? KupacId { get; set; }
        public virtual Korisnik Kupac { get; set; }

    }
}
