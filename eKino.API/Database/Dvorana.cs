using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class Dvorana
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int BrojRedova { get; set; }
        public int BrojKolona { get; set; }
        public DateTime Pocetak_RadnogVremena { get; set; }
        public DateTime Kraj_RadnogVremena { get; set; }

        [ForeignKey(nameof(GradId))]
        public int GradId { get; set; }
        public virtual Grad Grad { get; set; }

    }
}
