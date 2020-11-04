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
    public class RezervacijaAktuelnoViewModel : BaseViewModel
    {
        private readonly ApiService _rezervacijeService = new ApiService("Rezervacija");
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _projekcijeService = new ApiService("Projekcija");
        private readonly ApiService _filmService = new ApiService("Film");
        private readonly ApiService _dvoranaService = new ApiService("Dvorana");
        ICommand InitCommand;
        public RezervacijaAktuelnoViewModel()
        {
            InitCommand = new Command(() => { Init(true, true); });
        }

        private List<Rezervacija> _rezervacijeList = new List<Rezervacija>();
        public List<Rezervacija> RezervacijeList
        {
            get { return _rezervacijeList; }
            set { SetProperty(ref _rezervacijeList, value); }
        }

        private List<Projekcija> _projekcijeList = new List<Projekcija>();
        public List<Projekcija> ProjekcijeList
        {
            get { return _projekcijeList; }
            set { SetProperty(ref _projekcijeList, value); }
        }

        private List<Film> _filmoviList = new List<Film>();
        public List<Film> FilmoviList
        {
            get { return _filmoviList; }
            set { SetProperty(ref _filmoviList, value); }
        }

        private List<Dvorana> _dvoranaList = new List<Dvorana>();
        public List<Dvorana> DvoranaList
        {
            get { return _dvoranaList; }
            set { SetProperty(ref _dvoranaList, value); }
        }

        public void Init(bool aktivne, bool neaktivne)
        {
            RezervacijeZaIspis.Clear();
            var k = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            if (k != null)
            {
                if (RezervacijeList.Count() == 0)
                    RezervacijeList = _rezervacijeService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id });
                var rez = RezervacijeList;
                if (ProjekcijeList.Count() == 0)
                    ProjekcijeList = _projekcijeService.Get<List<Projekcija>>();
                var projekcije = ProjekcijeList;
                if (FilmoviList.Count() == 0)
                    FilmoviList = _filmService.Get<List<Film>>();
                if (DvoranaList.Count() == 0)
                    DvoranaList = _dvoranaService.Get<List<Dvorana>>();

                int br = 1;
                foreach (var r in rez)
                {
                    var p = projekcije.Where(w => w.Id == r.ProjekcijaId).FirstOrDefault();

                    if (!neaktivne)
                    {
                        if (p.DatumProjekcije.CompareTo(DateTime.Now) < 0)
                            continue;
                    }
                    if (!aktivne)
                    {
                        if (p.DatumProjekcije.CompareTo(DateTime.Now) > 0)
                            continue;
                    }

                    RezervacijeZaIspis.Add(new Model_VM
                    {
                        Id = r.Id,
                        RedniBroj = br,
                        DatumRezervacije = r.DatumKreirnja.ToString("dd/MM/yyyy"),
                        Film = FilmoviList.Where(w => w.Id == p.FilmId).Select(s => s.Naziv).FirstOrDefault(),
                        Dvorana = DvoranaList.Where(w => w.Id == p.DvoranaId).Select(s => s.Naziv).FirstOrDefault(),
                        Cijena = p.CijenaUlaznice,
                        DatumProjekcije = p.DatumProjekcije.ToString("dd/MM/yyyy"),
                        Sjediste = (Convert.ToChar(r.SjedisteRed + 65)).ToString() + "/" + (r.SjedisteKolona + 1)
                    }) ;
                    br++;
                }
            }
        }

        public List<Model_VM> RezervacijeZaIspis = new List<Model_VM>();
        public class Model_VM
        {
            public int Id { get; set; }
            public int RedniBroj { get; set; }
            public string DatumRezervacije { get; set; }
            public string Film { get; set; }
            public string Dvorana { get; set; }
            public double Cijena { get; set; }
            public string DatumProjekcije { get; set; }
            public string Sjediste { get; set; }

        }
    }
}
