using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class FilmScenaristiInsertRequest
    {
        public int FilmId { get; set; }
        public int ScenaristId { get; set; }
    }
}
