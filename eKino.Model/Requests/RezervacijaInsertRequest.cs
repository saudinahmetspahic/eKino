using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public DateTime DatumKreirnja { get; set; }
        public int? ProjekcijaId { get; set; }
        public int? KupacId { get; set; }
        public int SjedisteRed { get; set; }
        public int SjedisteKolona { get; set; }
    }
}
