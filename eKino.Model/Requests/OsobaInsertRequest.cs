using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class OsobaInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Biografija { get; set; }
        public int? GradId { get; set; }
        public int UlogaId { get; set; }
    }
}
