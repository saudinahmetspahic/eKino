using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Biografija { get; set; }

        [ForeignKey(nameof(GradId))]
        public int? GradId { get; set; }
        public virtual Grad Grad { get; set; }        
    }
}
