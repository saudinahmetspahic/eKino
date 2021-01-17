using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KorisnikSearchRequest
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
