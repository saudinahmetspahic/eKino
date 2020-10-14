using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class Dvorana
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int BrojRedova { get; set; }
        public int BrojKolona { get; set; }
        public DateTime Pocetak_RadnogVremena { get; set; }
        public DateTime Kraj_RadnogVremena { get; set; }
        public int GradId { get; set; }

        private string _Info;
        public string Info { get { return string.IsNullOrEmpty(_Info) == true ? Naziv + " (" + BrojRedova + "r/" + BrojKolona + "k)" : _Info; } set { _Info = value; } }
    }
}
