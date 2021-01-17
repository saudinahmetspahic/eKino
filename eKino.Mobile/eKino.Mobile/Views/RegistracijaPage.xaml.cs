using eKino.Mobile.Models;
using eKino.Mobile.ViewModels;
using eKino.Model;
using eKino.Model.Requests;
using Flurl.Util;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
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
            GradoviListaPicker.ItemsSource = model.GradoviLista;
            base.OnAppearing();
            model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Validation())
                return;
           
            var korisnik = new KorisnikInsertRequest
            {
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = DatumRodjenja.Date,
                Email = Email.Text,
                Password = Sifra.Text,
                PasswordPotvrda = SifraPotvrda.Text,
                Ime = Ime.Text,
                Prezime = Prezime.Text,
                UlogaId = _ulogaService.Get<List<Uloga>>(new UlogaSearchRequest { NazivUloge = "User" }).Select(s => s.Id).FirstOrDefault(), //_ulogaService.GetByName<Uloga>("User").Id,
                GradId = ((Grad)GradoviListaPicker.SelectedItem).Id
            };
            _korisnikService.Add(korisnik);
            await Task.Delay(2000);
            var k = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = Email.Text }).FirstOrDefault();
            if (k != null)
            {
                await Navigation.PopToRootAsync();
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Vas racun nije kreiran. Pokusajte ponovno.", "Ok");
            }
        }

        private bool Validation()
        {
            if(string.IsNullOrEmpty(Ime.Text))
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Morate unijeti ime.", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(Prezime.Text))
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Morate unijeti prezime.", "Ok");
                return false;
            }
            if (GradoviListaPicker.SelectedIndex < 0)  
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Morate odabrati grad.", "Ok");
                return false;
            }

            try
            {
                MailAddress mail = new MailAddress(Email.Text);
            }
            catch (Exception)
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Morate unijeti ispravan email.", "Ok");
                return false;
            }

            if (string.IsNullOrEmpty(Sifra.Text))
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Morate unijeti lozinku.", "Ok");
                return false;
            }

            if (Sifra.Text != SifraPotvrda.Text)
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Unijeli ste dvije različite lozinke.", "Ok");
                return false;
            }


            return true;
        }
    }
}