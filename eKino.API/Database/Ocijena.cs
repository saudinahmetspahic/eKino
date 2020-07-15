using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class Ocijena
    {
        public int Id { get; set; }
        public int Ocijena1 { get; set; }
        public string Komentar { get; set; }

        [ForeignKey(nameof(KomentatorId))]
        public int KomentatorId { get; set; }
        public virtual Korisnik Komentator { get; set; }

        [ForeignKey(nameof(FilmId))]
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }

    }
}
