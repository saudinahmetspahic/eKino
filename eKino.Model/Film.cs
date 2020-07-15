using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string Zanr { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIzlaska { get; set; }
    }
}
