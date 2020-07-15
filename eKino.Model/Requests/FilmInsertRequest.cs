using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class FilmInsertRequest
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIzlaska { get; set; }
        public int TipId { get; set; }
        public int ZanrId { get; set; }
    }
}
