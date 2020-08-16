using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KorisnikInsertRequest
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public int UlogaId { get; set; }
        public int GradId { get; set; }
    }
}
