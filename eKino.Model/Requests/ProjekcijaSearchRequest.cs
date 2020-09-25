using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class ProjekcijaSearchRequest
    {
        public DateTime DatumProjekcije { get; set; }
        public int FilmId { get; set; }
        public int DvoranaId { get; set; }


    }
}
