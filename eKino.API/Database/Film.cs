using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKino.API.Database
{
    public class Film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIzlaska { get; set; }

        [ForeignKey(nameof(TipId))]
        public int TipId { get; set; }
        public virtual Tip Tip { get; set; }

        [ForeignKey(nameof(ZanrId))]
        public int ZanrId { get; set; }
        public virtual Zanr Zanr { get; set; }

        public string Link { get; set; }
        public byte[] Slika { get; set; }
    }
}
