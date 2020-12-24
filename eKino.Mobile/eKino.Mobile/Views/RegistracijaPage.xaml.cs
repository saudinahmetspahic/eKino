using eKino.Mobile.Models;
using eKino.Mobile.ViewModels;
using eKino.Model;
using eKino.Model.Requests;
using Flurl.Util;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private LoginViewModel model;
        public RegistracijaPage()
        {
            InitializeComponent();
            model = new LoginViewModel();
            BindingContext = model;
        }

        protected override void OnAppearing()
        {
            GradoviListaPiceker.ItemsSource = model.GradoviLista;
            base.OnAppearing();
            model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Sifra.Text != SifraPotvrda.Text)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Unijeli ste dvije različite lozinke.", "Ok");
                return;
            }

            ApiService.Email = "admin@app.com";
            ApiService.Sifra = "Admin12345";
            var korisnik = new KorisnikInsertRequest
            {
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = DatumRodjenja.Date,
                Email = Email.Text,
                Password = Sifra.Text,
                PasswordPotvrda = SifraPotvrda.Text,
                Ime = Ime.Text,
                Prezime = Prezime.Text,
                UlogaId = _ulogaService.GetByName<Uloga>("User").Id,
                GradId = ((Grad)GradoviListaPiceker.SelectedItem).Id
            };
            _korisnikService.Add(korisnik);
            await Task.Delay(2000);
            var k = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = Email.Text }).FirstOrDefault();
            if(k != null)
            {
                await Navigation.PopToRootAsync();
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Vas racun nije kreiran. Pokusajte ponovno.", "Ok");
            }
        }
    }
}