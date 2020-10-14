using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class PaketInsertRequest
    {
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int MaxOcijena { get; set; } 
        public string Opis { get; set; }
        public double Cijena { get; set; }
    }
}
