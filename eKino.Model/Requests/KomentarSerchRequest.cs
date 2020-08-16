using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KomentarSerchRequest
    {
        public string SadrzajKomentara { get; set; }

        public int KomentatorId { get; set; }
        public virtual Korisnik Komentator { get; set; }

        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
