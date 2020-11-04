using eKino.Mobile.Helper;
using eKino.Mobile.ViewModels;
using eKino.Model;
using eKino.Model.Requests;
using PayPal.Forms;
using PayPal.Forms.Abstractions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaketDetaljiPage : ContentPage
    {
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly ApiService _KorisnikService = new ApiService("Korisnik");
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        private PaketDetaljiViewModel model;
        public PaketDetaljiPage(int paketId)
        {
            InitializeComponent();
            BindingContext = model = new PaketDetaljiViewModel(paketId);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();

            var k = _KorisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            var u = _ulogaService.GetById<Uloga>(k.UlogaId);
            if (u != null && u.NazivUloge == "Admin")
            {
                IzbrisiButton.IsVisible = true;
                SnimiButton.IsVisible = true;
            }
            else
            {
                IzbrisiButton.IsVisible = false;
                SnimiButton.IsVisible = false;
            }
        }

        private async void IzbrisiPaket_Clicked(object sender, EventArgs e)
        {
            _paketService.Remove(model.PaketId);
            await Navigation.PopAsync();
        }

        private void SnimiIzmjene_Clicked(object sender, EventArgs e)
        {
            var m = new PaketInsertRequest
            {
                Cijena = double.Parse(CijenaPaketa.Text),
                MaxOcijena = int.Parse(MaxOcijena.Text),
                DatumIsteka = DatumIsteka.Date,
                Opis = Opis.Text,
                DatumKreiranja = DatumKreiranja.Date
            };
            _paketService.Update<PaketInsertRequest>(model.PaketId, m);
            MsgFrame.IsVisible = true;
            Msg.Text = "Podaci su uspijesno izmijenjeni.";
            Device.StartTimer(TimeSpan.FromSeconds(5000), () =>
            {
                MsgFrame.IsVisible = false;
                Msg.Text = string.Empty;
                return false; // false zaustavlja timer
            });
        }



        /// <summary>
        /// PayPal placanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private static int PAYPAL_REQUEST_CODE = 7171;
        private static PayPalConfiguration configuration = new PayPalConfiguration(PayPalEnvironment.Sandbox, eKino.Mobile.Helper.PayPal.Client_ID);

        private async void KupiPaket_Clicked(object sender, EventArgs e)
        {
            var cijena = model.Cijena;
            var result = await CrossPayPalManager.Current.Buy(new PayPalItem("Test Product", new Decimal(cijena), "BAM"), new Decimal(0));
            if (result.Status == PayPalStatus.Cancelled)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Odbijeno", "Ok");
            }
            else if (result.Status == PayPalStatus.Error)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Nepoznata greska", "Ok");
            }
            else if (result.Status == PayPalStatus.Successful)
            {
                await Application.Current.MainPage.DisplayAlert("Potvrda", "Placanje uspiješno.", "Ok");
            }

            

        }
    }
}