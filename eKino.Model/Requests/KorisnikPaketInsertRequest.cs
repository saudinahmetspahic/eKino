using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KorisnikPaketInsertRequest
    {
        public int KorisnikId { get; set; }
        public int PaketId { get; set; }
    }
}
