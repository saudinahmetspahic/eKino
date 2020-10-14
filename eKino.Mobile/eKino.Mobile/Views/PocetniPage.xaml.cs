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
            }
            else
            {
                iconToShow.IsVisible = true;
                gridToShow.IsVisible = false;
            }
        }

        private async void AvatarIcon_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }
    }
}