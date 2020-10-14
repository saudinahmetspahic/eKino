using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KomentarSearchRequest
    {
        public string SadrzajKomentara { get; set; }
        public int KomentatorId { get; set; }
        public int FilmId { get; set; }
    }
}
