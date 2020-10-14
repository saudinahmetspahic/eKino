using eKino.Mobile.ViewModels;
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
    public partial class AccountPage : ContentPage
    {
        private StatistikaViewModel model;
        public AccountPage()
        {
            InitializeComponent();
            BindingContext = model = new StatistikaViewModel();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private void OdjaviSe_Button(object sender, EventArgs e)
        {
            ApiService.Email = string.Empty;
            ApiService.Sifra = string.Empty;
            Navigation.PopToRootAsync();
            Navigation.PushAsync(new LoginPage());
        }    
        
        private void Uredi_Button(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new AccountUrediPage());
        }
    }
}