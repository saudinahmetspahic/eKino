using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class KorisnikPaket
    {
        public int Id { get; set; }

        [ForeignKey(nameof(KorisnikId))]
        public int KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(PaketId))]
        public int PaketId { get; set; }
        public virtual Paket Paket { get; set; }

    }
}
