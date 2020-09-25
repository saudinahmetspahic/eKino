using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model
{
    public class ProdukcijskaKuca
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public int? GradId { get; set; }
        public virtual Grad Grad { get; set; }
    }
}
