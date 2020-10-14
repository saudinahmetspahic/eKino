using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KomentarInsertRequest
    {
        public int Id { get; set; }
        public string SadrzajKomentara { get; set; }

        public int KomentatorId { get; set; }
        public int FilmId { get; set; }
    }
}
