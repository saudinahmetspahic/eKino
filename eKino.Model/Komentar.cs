using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Komentar
    {
        public int Id { get;  set; }
        public string SadrzajKomentara { get; set; }
        public List<int> Likes { get; set; }

        public int KomentatorId { get; set; }
        public virtual Korisnik Komentator { get; set; }

        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
