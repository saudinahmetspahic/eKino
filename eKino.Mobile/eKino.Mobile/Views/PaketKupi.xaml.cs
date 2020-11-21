using eKino.Mobile.Models;
using eKino.Mobile.ViewModels;
using eKino.Model;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaketKupi : ContentPage
    {
        private PaketKupiVM model;
        public PaketKupi(int PaketId, double Cijena)
        {
            InitializeComponent();
            BindingContext = model = new PaketKupiVM(PaketId, Cijena);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private void KupiPaket_Clicked(object sender, EventArgs e)
        {
            if (cvcKartice.Text.Length < 3 || cvcKartice.Text.Length > 4 || brojKartice.Text.Length != 16)
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Broj kartice mora sadrzavati 12 brojeva, a CVC mora sadrzavati 3 ili 4 broja", "Ok");
            }
            else Payment();
        }


        private void Payment()
        {

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            try
            {
                Task.Run(() =>
                {
                    var t = CreateToken();
                    if (t != null)
                    {
                        MakePayment();
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Greska", "Pogresni podaci", "Ok");
                    }
                });
            }
            catch (Exception)
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Server greska.", "Ok");
            }
        }

        public Token stripeToken;
        public TokenService TokenService;
        public string TestApiKey = "pk_test_51HoUdtIMEgSAkndunIH0wHhOLqWtusSeMBypB8gWlyCMzhDOfL90LPgCtqYIRHHaSDx37cMyB52NstBTULjjJsk500GjjQMy01";
        private bool MakePayment()
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51HoUdtIMEgSAkndur6EU84kDlaZEkXD99KVaoaMCw2QpIZegb8I5YTnUbUDQ4xNR3x6JR3gyWaURvdJ4O2GFq7yW00dsG6QHEk";



                var options = new PaymentIntentCreateOptions
                {
                    Amount = (long?)model.Cijena * 100,
                    Currency = "bam",
                    PaymentMethod = ((Item)metodaPlacanja.SelectedItem).Id,
                    OffSession = false,
                    Confirm = true
                };

                var service = new PaymentIntentService();
                var intent = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Greska", ex.Message, "Ok");
            }
            return false;
        }

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey = TestApiKey;
                var service = new ChargeService();
                var tokenOption = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = brojKartice.Text.ToString(),
                        ExpYear = 21,
                        ExpMonth = 12,
                        Cvc = cvcKartice.Text.ToString(),
                        Name = "Kupovina paketa eKino - " + model.Paket.Opis,
                        AddressLine1 = "Adresa",
                        AddressLine2 = "Adresa"
                    }
                };
                TokenService = new TokenService();
                stripeToken = TokenService.Create(tokenOption);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Greska", ex.Message, "Ok");
            }
            return string.Empty;
        }

    }
}