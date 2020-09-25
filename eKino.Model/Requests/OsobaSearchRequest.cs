using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class OsobaSearchRequest
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }
    }
}
