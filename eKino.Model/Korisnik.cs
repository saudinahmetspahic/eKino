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
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }

        public int UlogaId { get; set; }
        public Uloga Uloga { get; set; }

        public int GradId { get; set; }
        public Grad Grad { get; set; }
    }
}
