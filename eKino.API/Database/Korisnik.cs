using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Database
{
    public class Korisnik : Osoba
    {
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public byte[] Slika { get; set; }
    }
}
