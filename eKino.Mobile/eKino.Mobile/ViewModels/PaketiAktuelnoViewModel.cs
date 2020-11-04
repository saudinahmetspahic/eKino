using eKino.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml.Internals;

namespace eKino.Mobile.ViewModels
{
    public class PaketiAktuelnoViewModel : BaseViewModel
    {
        private readonly ApiService _paketiService = new ApiService("Paket");

        ICommand InitCommand;
        public PaketiAktuelnoViewModel()
        {
            InitCommand = new Command(() => { Init(); });
        }

        private List<Paket> _paketiLista = new List<Paket>();
        public List<Paket> PaketiLista
        {
            get { return _paketiLista; }
            set { SetProperty(ref _paketiLista, value); }
        }

        public void Init()
        {
            _paketiLista = _paketiService.Get<List<Paket>>();
        }
    }
}
