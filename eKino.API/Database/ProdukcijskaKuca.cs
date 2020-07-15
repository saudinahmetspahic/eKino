using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class ProdukcijskaKuca
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        [ForeignKey(nameof(GradId))]
        public int? GradId { get; set; }
        public virtual Grad Grad { get; set; }
    }
}
