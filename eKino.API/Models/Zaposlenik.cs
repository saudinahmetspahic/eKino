using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Models
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }

        [ForeignKey(nameof(DvoranaId))]
        public int DvoranaId { get; set; }
        public virtual Dvorana Dvorana { get; set; }
    }
}
