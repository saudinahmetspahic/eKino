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
    public class EditAccountaViewModel : BaseViewModel
    {
        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        private DateTime _datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }
        private string _grad;
        public string Grad
        {
            get { return _grad; }
            set { SetProperty(ref _grad, value); }
        }
        private string _lozinka;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        private string _potvrdaLozinke;
        public string PotvrdaLozinke
        {
            get { return _potvrdaLozinke; }
            set { SetProperty(ref _potvrdaLozinke, value); }
        }
        public ObservableCollection<Grad> Gradovi { get; set; } = new ObservableCollection<Grad>();
        public Grad _odabraniGrad;
        public Grad OdabraniGrad
        {
            get { return _odabraniGrad; }
            set { SetProperty(ref _odabraniGrad, value); }
        }

        private ICommand InitCommand;
        public EditAccountaViewModel()
        {
            InitCommand = new Command(() => Init());
        }

        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _gradService = new ApiService("Grad");
        public void Init()
        {
            var req = new KorisnikSearchRequest { Email = ApiService.Email };
            var _korisnik = _korisnikService.Get<List<Korisnik>>(req).FirstOrDefault();

            if (_korisnik != null)
            {
                Ime = _korisnik.Ime;
                Prezime = _korisnik.Prezime;
                Email = _korisnik.Email;
                DatumRodjenja = _korisnik.DatumRodjenja;               
                var gradoviList = _gradService.Get<List<Grad>>(null);
                gradoviList.Insert(0, new Model.Grad { Id = 0, Naziv = "Odaberite grad" });
                foreach (var g in gradoviList)
                {
                    Gradovi.Add(g); 
                }
                OdabraniGrad = Gradovi.Where(w => w.Id == _korisnik.GradId).FirstOrDefault(); //_gradService.GetById<Grad>(_korisnik.GradId);
            }

        }

    }
}
