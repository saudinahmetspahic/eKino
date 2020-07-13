using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Models
{
    public class FilmProdukcijskeKuce
    {
        [ForeignKey(nameof(FilmId))]
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }

        [ForeignKey(nameof(ProdukcijskaKucaId))]
        public int ProdukcijskaKucaId { get; set; }
        public virtual ProdukcijskaKuca ProdukcijskaKuca { get; set; }

    }
}
