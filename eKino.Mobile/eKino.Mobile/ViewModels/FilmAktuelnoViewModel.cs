using eKino.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class FilmAktuelnoViewModel : BaseViewModel
    {
        private readonly ApiService _filmoviService = new ApiService("Film");
        private readonly ApiService _zanroviService = new ApiService("Zanr");
        private readonly ApiService _tipoviService = new ApiService("Tip");
        ICommand InitCommand;
        public FilmAktuelnoViewModel()
        {
            InitCommand = new Command(() => { Init(); });
        }

        public void Init()
        {
            FilmoviList = _filmoviService.Get<List<Film>>();
            ZanroviList = _zanroviService.Get<List<Zanr>>();
            TipoviList = _tipoviService.Get<List<Tip>>();
        }

        public List<Film> FilmoviList = new List<Film>();
        public List<Zanr> ZanroviList = new List<Zanr>();
        public List<Tip> TipoviList = new List<Tip>();



    }
}
