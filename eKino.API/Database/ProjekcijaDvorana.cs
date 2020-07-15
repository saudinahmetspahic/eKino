using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class ProjekcijaDvorana
    {
        [ForeignKey(nameof(ProjekcijaId))]
        public int ProjekcijaId { get; set; }
        public virtual Projekcija Projekcija { get; set; }

        [ForeignKey(nameof(DvoranaId))]
        public int DvoranaId { get; set; }
        public virtual Dvorana Dvorana { get; set; }

    }
}
