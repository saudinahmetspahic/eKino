using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Database
{
    public class Prijava
    {
        public int Id { get; set; }

        [ForeignKey(nameof(FilmId))]
        public int FilmId { get; set; }
        public Film Film { get; set; }

        [ForeignKey(nameof(FilmId))]
        public int PrijavioId { get; set; }
        public Korisnik Prijavio { get; set; }

        public string Opis { get; set; }
        public string VlasnikAutPrava { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; } 
        public bool Rijeseno { get; set; }
    }
}
