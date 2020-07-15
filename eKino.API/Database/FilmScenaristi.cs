using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class FilmScenaristi
    {
        [ForeignKey(nameof(FilmId))]
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }

        [ForeignKey(nameof(ScenaristId))]
        public int ScenaristId { get; set; }
        public virtual Osoba Scenarist { get; set; }
    }
}
