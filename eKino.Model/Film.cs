using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int TipId { get; set; }
        public int ZanrId { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIzlaska { get; set; }
        public byte[] Slika { get; set; }
        public string Link { get; set; }
    }
}
