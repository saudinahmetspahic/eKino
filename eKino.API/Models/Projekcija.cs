using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Models
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
    }
}
