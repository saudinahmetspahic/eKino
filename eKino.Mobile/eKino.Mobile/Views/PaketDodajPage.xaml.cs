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
    public partial class PaketDodajPage : ContentPage
    {
        private readonly ApiService _paketService = new ApiService("Paket");
        public PaketDodajPage()
        {
            InitializeComponent();
        }

        private async void DodajPaket_Clicked(object seder, EventArgs e)
        {
            if (!Validation())
                return;

            var o = int.Parse(MaxOcijena.Text);
            if (o < 1 || o > 5)
                    return;
            var paket = new PaketInsertRequest
            {
                Cijena = double.Parse(CijenaPaketa.Text),
                DatumIsteka = DatumIsteka.Date,
                DatumKreiranja = DateTime.Now,
                Opis = Opis.Text,
                MaxOcijena = o
            };
            _paketService.Add(paket);
            await Navigation.PopAsync();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(Opis.Text))
            {
                DisplayAlert("Greska", "Morate unijeti opis.", "Ok");
                return false;
            }
            if (!int.TryParse(MaxOcijena.Text, out int x) || x < 1 || x > 5)
            {
                DisplayAlert("Greska", "Maksimalna ocijena se unosi brojem od 1 do 5.", "Ok");
                return false;
            }
            if (!int.TryParse(CijenaPaketa.Text, out int xx) || xx < 0)
            {
                DisplayAlert("Greska", "Cijena paketa se unosi brojem.", "Ok");
                return false;
            }
            return true;
        }
    }
}