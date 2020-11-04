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
    public partial class AccountUrediPage : ContentPage
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private EditAccountaViewModel model;
        public AccountUrediPage()
        {
            InitializeComponent();
            BindingContext = model = new EditAccountaViewModel();
        }

        protected override void OnAppearing()
        {
            Gradovi.ItemsSource = model.Gradovi;
            Gradovi.SelectedItem = model.OdabraniGrad;
            base.OnAppearing();
            model.Init();
        }

        private void SnimiButton_Clicked(object sender, EventArgs e)
        {
            if (Lozinka.Text != PotvrdaLozinka.Text)
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Lozinke se ne poklapaju.", "Ok");
                return;
            }
            var _korisnik = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            var req = new KorisnikInsertRequest
            {
                Ime = Ime.Text,
                Prezime = Prezime.Text,
                Email = Email.Text,
                GradId = ((Grad)Gradovi.SelectedItem).Id,
                UlogaId = _korisnik.UlogaId,
                DatumRodjenja = DatumRodjenja.Date,
                DatumRegistracije = _korisnik.DatumRegistracije,
                Password = Lozinka.Text,
                PasswordPotvrda = Lozinka.Text
            };
            _korisnikService.Update<Korisnik>(_korisnik.Id, req);
            Navigation.PopAsync();
        }
    }
}