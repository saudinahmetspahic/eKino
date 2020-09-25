using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Projekcija
    {
        public int Id { get; set; }
        public double CijenaUlaznice { get; set; }
        public string Opis { get; set; }
        public DateTime DatumProjekcije { get; set; }

        public int FilmId { get; set; }

        public int DvoranaId { get; set; }

    }
}
