using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class PaketSearchRequest
    {
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int MaxOcijena { get; set; }
        public double Cijena { get; set; }
    }
}
