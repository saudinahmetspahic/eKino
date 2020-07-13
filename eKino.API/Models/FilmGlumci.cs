using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Models
{
    public class FilmGlumci
    {
        [ForeignKey(nameof(FilmId))]
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }


        [ForeignKey(nameof(GlumacId))]
        public int GlumacId { get; set; }
        public virtual Osoba Glumac { get; set; }
    }
}
