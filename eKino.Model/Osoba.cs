using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get { return Ime + " " + Prezime; } }
        public string Uloga { get; set; }
    }
}
