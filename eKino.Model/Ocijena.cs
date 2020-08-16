using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Ocijena
    {
        public int Ocijena1 { get; set; }
        public string Komentar { get; set; }

        public int KomentatorId { get; set; }
        public virtual Korisnik Komentator { get; set; }

        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
