using eKino.Mobile.ViewModels;
using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmPrijavi : ContentPage
    {
        private int _filmId;
        private FilmDetaljiViewModel _model;
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _prijaveService = new ApiService("Prijava");
        public FilmPrijavi(FilmDetaljiViewModel model, int filmId)
        {
            BindingContext = _model = model;
            _filmId = filmId;
            InitializeComponent();
        }

        private void PrijaviFilm_Clicked(object sender, EventArgs e)
        {
            var k = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            _prijaveService.Add(new PrijavaInsertRequest
            {
                FilmId = _filmId,
                Email = TxtEmail.Text,
                Opis = TxtOpis.Text,
                Telefon = TxtTel.Text,
                VlasnikAutPrava = TxtAutor.Text,
                Rijeseno = false,
                PrijavioId = k.Id
            });
            Application.Current.MainPage.DisplayAlert("Potvrda", "Vasa prijava je zabilježena.", "Ok");
            Navigation.PopAsync();
        }
    }
}