using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class FilmScenaristi
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int ScenaristId { get; set; }
        public Osoba Scenarist { get; set; }
    }
}
