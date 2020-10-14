using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class RezervacijaSearchRequest
    {
        public int KorisnikId { get; set; }

        public int ProjekcijaId { get; set; }
    }
}
