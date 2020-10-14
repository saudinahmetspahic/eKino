using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class StatistikaViewModel : BaseViewModel
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly ApiService _korisnikPaketService = new ApiService("KorisnikPaket");
        private readonly ApiService _ocijenaService = new ApiService("Ocijena");
        private readonly ApiService _rezervacijaService = new ApiService("Rezervacija");
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        private readonly ApiService _komentarService = new ApiService("Komentar");
        private readonly ApiService _komentarReakcijaService = new ApiService("KomentarReakcija");
        private ICommand InitCommand;

        public StatistikaViewModel()
        {
            InitCommand = new Command(() => { Init(); });
        }

        private string _imePrezime;
        public string ImePrezime 
        {
            get { return _imePrezime; }
            set { SetProperty(ref _imePrezime, value); }
        }
        private string _datumRegistracije;
        public string DatumRegistracije
        {
            get { return _datumRegistracije; }
            set { SetProperty(ref _datumRegistracije, value); }
        }
        private string _paket;
        public string Paket
        {
            get { return _paket; }
            set { SetProperty(ref _paket, value); }
        }
        private string _brojRezervacija;
        public string BrojRezervacija
        {
            get { return _brojRezervacija; }
            set { SetProperty(ref _brojRezervacija, value); }
        }
        private string _najPopularnijiKomentar;
        public string NajpopKomentar
        {
            get { return _najPopularnijiKomentar; }
            set { SetProperty(ref _najPopularnijiKomentar, value); }
        }
        private string _brojOcijena;
        public string BrojOcijena
        {
            get { return _brojOcijena; }
            set { SetProperty(ref _brojOcijena, value); }
        }
        private string _uloga;
        public string Uloga
        {
            get { return _uloga; }
            set { SetProperty(ref _uloga, value); }
        }

        public void Init()
        {
            var req = new KorisnikSearchRequest { Email = ApiService.Email };
            var k = _korisnikService.Get<List<Korisnik>>(req).FirstOrDefault();


            if (k != null)
            {
                ImePrezime = k.Ime + " " + k.Prezime;
                DatumRegistracije = k.DatumRegistracije.ToString("dd-MM-yyyy");
                var search = new KorisnikPaketSearchRequest { KorisnikId = k.Id };
                var kp = _korisnikPaketService.Get<List<KorisnikPaket>>(search).FirstOrDefault();
                Paket = _paketService.GetById<Paket>(kp?.PaketId ?? 0)?.Opis ?? "-";
                BrojOcijena = _ocijenaService.Get<List<Ocijena>>(new OcijenaSearchRequest { KorisnikId = k.Id })?.Count.ToString();
                BrojRezervacija = _rezervacijaService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id })?.Count.ToString();
                var komentari = _komentarService.Get<List<Komentar>>(new KomentarSearchRequest { KomentatorId = k.Id });
                var maxReakcija = 0;
                string kom = "";
                foreach (var komentar in komentari)
                {
                    var reakcije = _komentarReakcijaService.Get<List<KomentarReakcija>>(new KomentarReakcijaSearchRequest { KomentarId = komentar.Id, Reakcija = Model.Requests.ReakcijaTip.Like });
                    int brojReakcija = reakcije.Count;
                    if (brojReakcija >= maxReakcija)
                    {
                        maxReakcija = brojReakcija;
                        kom = komentar.SadrzajKomentara;
                    }
                }
                NajpopKomentar = "[" + maxReakcija.ToString() + " 👍] Komentar: " + kom;
                Uloga = _ulogaService.GetById<Uloga>(k.UlogaId).NazivUloge;
            }
        }
    }
}
