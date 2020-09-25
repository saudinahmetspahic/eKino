using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Paket
    {
        public int Id { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public int MaxOcijena { get; set; } // filmova
        public string Opis { get; set; }
        public double? Cijena { get; set; }
    }
}
