using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Dvorana
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public short BrojSjedista { get; set; }
        public DateTime Pocetak_RadnogVremena { get; set; }
        public DateTime Kraj_RadnogVremena { get; set; }
        public int GradId { get; set; }
        public string Info { get { return Naziv + " (" + BrojSjedista + " sj.)"; } set { } }
    }
}
