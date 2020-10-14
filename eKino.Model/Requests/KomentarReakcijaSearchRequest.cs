using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public enum ReakcijaTip { Like, Dislike };
    public class KomentarReakcijaSearchRequest
    {
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        public int KomentarId { get; set; }
        public Komentar Komentar { get; set; }

        public ReakcijaTip Reakcija { get; set; }
    }
}
