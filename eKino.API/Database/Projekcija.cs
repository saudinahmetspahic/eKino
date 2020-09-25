using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class Projekcija
    {
        public int Id { get; set; }
        public double CijenaUlaznice { get; set; }
        public string Opis { get; set; }
        public DateTime DatumProjekcije { get; set; }

        [ForeignKey(nameof(FilmId))]
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }

        [ForeignKey(nameof(DvoranaId))]
        public int DvoranaId { get; set; }
        public virtual Dvorana Dvorana { get; set; }
    }
}
