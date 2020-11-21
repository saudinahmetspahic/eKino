using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eKino.Model
{
    public class PreporuceniFilmovi
    {
        public int FilmId { get; set; }
        public string NazivFilma { get; set; }
        public string Opis { get; set; }
        public ImageSource Slika { get; set; }
    }
}
