using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Ocijena
    {
        public int Id { get; set; }
        public int DataOcijena { get; set; }

        public int KomentatorId { get; set; }
        public Korisnik Komentator { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
