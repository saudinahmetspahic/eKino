using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Rpt_Filmovi_Result
    {
        public string Naziv { get; set; }
        public string NazivZanra { get; set; }
        public string NazivTipa { get; set; }
        public int BrojProjekcija { get; set; }
        public float UkupnaZarada { get; set; }
        public int OcijenaFilma { get; set; }
    }
}
