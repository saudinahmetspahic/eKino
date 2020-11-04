using eKino.Mobile.ViewModels;
using eKino.Model;
using eKino.Model.Helper;
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
    public partial class PocetniPage : ContentPage
    {

        public PocetniPage()
        {
            InitializeComponent();
            //BindingContext = new PocetniViewModel();
            
        }

        private void MeniIcon_Tapped(object sender, EventArgs e)
        {
            if (iconToShow.IsVisible)
            {
                iconToShow.IsVisible = false;
                gridToShow.IsVisible = true;
                mainStack.BackgroundColor = Color.Gray;
            }
            else
            {
                iconToShow.IsVisible = true;
                gridToShow.IsVisible = false;
                mainStack.BackgroundColor = Color.White;
            }
        }

        private async void AvatarIcon_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }



        private async void PaketAktuelno_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaketAktuelnoPage());
        }

        private async void PaketDodaj_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaketDodajPage());
        }

        private async void ProjekcijaAktuelno_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjekcijaAktuelnoPage());
        }

        private async void ProjekcijaDodaj_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijaDodajPage());
        }

        private async void FilmAktuelno_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilmAktuelnoPage());
        }

    }
}