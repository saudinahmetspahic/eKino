using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Database
{
    public enum ReakcijaTip { Like, Dislike };
    public class KomentarReakcija
    {        
        [ForeignKey(nameof(KorisnikId))]
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(KomentarId))]
        public int KomentarId { get; set; }
        public Komentar Komentar { get; set; }

        public ReakcijaTip Reakcija { get; set; }
    }
}
