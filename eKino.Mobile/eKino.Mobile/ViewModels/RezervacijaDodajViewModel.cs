using eKino.Mobile.Views;
using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class RezervacijaDodajViewModel : BaseViewModel
    {
        ICommand InitCommand;
        public RezervacijaDodajViewModel()
        {
            InitCommand = new Command(() => { Init(); });
        }

        private readonly ApiService _projekcijeService = new ApiService("Projekcija");
        private readonly ApiService _dvoraneService = new ApiService("Dvorana");
        private readonly ApiService _rezervacijeService = new ApiService("Rezervacija");

        private List<Dvorana> _dvoraneList = new List<Dvorana>();
        public List<Dvorana> DvoraneList
        {
            get { return _dvoraneList; }
            set { SetProperty(ref _dvoraneList, value); }
        }

        private ObservableCollection<Projekcija> _projekcijeList = new ObservableCollection<Projekcija>();
        public ObservableCollection<Projekcija> ProjekcijeList
        {
            get { return _projekcijeList; }
            set { SetProperty(ref _projekcijeList, value); }
        }

        private Projekcija _odabranaProjekcija = null;
        public Projekcija OdabranaProjekcija
        {
            get { return _odabranaProjekcija; }
            set { SetProperty(ref _odabranaProjekcija, value); }
        }

        private Dvorana _odabranaDvorana = null;
        public Dvorana OdabranaDvorana
        {
            get { return _odabranaDvorana; }
            set { SetProperty(ref _odabranaDvorana, value); }
        }

        private List<Tuple<int, int, int>> _zauzetaSjedista = new List<Tuple<int, int, int>>(); // kupacId, red, kolona
        public List<Tuple<int, int, int>> ZauzetaSjedista
        {
            get { return _zauzetaSjedista; }
            set { SetProperty(ref _zauzetaSjedista, value); }
        }

        public void Init()
        {
            if (DvoraneList.Count == 0)
                DvoraneList = _dvoraneService.Get<List<Dvorana>>();
            if (ProjekcijeList.Count == 0)
            {
                var pr = _projekcijeService.Get<List<Projekcija>>();
                foreach (var p in pr)
                {
                    ProjekcijeList.Add(p);  
                }
            }

            if (OdabranaProjekcija == null)
                return;

            OdabranaDvorana = DvoraneList.Where(w => w.Id == OdabranaProjekcija.DvoranaId).FirstOrDefault();

            var sjedista = _rezervacijeService.Get<List<Rezervacija>>(new RezervacijaSearchRequest
            {
                ProjekcijaId = OdabranaProjekcija.Id
            });
            ZauzetaSjedista.Clear();
            foreach (var sjediste in sjedista)
            {
                ZauzetaSjedista.Add(new Tuple<int, int, int>((int)sjediste.KupacId, sjediste.SjedisteRed, sjediste.SjedisteKolona));
            }

            
        }


    }
}
