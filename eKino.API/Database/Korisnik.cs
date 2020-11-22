using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.API.Database
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public bool SlanjeEmaila { get; set; }

        [ForeignKey(nameof(UlogaId))]
        public int UlogaId { get; set; }
        public Uloga Uloga { get; set; }

        [ForeignKey(nameof(GradId))]
        public int GradId { get; set; }
        public Grad Grad { get; set; }
    }
}
