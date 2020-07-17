using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Biografija { get; set; }
        public int? GradId { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public byte[] Slika { get; set; }
    }
}
