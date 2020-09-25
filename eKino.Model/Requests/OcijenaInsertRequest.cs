using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class OcijenaInsertRequest
    {
        public int DataOcijena { get; set; }
        public string Komentar { get; set; }

        public int KomentatorId { get; set; }
        public virtual Korisnik Komentator { get; set; }

        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}
