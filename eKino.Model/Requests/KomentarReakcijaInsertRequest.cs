using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class KomentarReakcijaInsertRequest
    {
        public int KorisnikId { get; set; }

        public int KomentarId { get; set; }

        public ReakcijaTip Reakcija { get; set; }
    }
}
