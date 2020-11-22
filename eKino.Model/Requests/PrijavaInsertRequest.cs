using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class PrijavaInsertRequest
    {

        public int FilmId { get; set; }
        public int PrijavioId { get; set; }
        public string Opis { get; set; }
        public string VlasnikAutPrava { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool Rijeseno { get; set; }
    }
}
