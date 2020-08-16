using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public enum ReakcijaTip { Like, Dislike };

    public class KomentarReakcija
    {
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        public int KomentarId { get; set; }
        public Komentar Komentar { get; set; }

        public ReakcijaTip Reakcija { get; set; }
    }
}
