using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        Entry email;
        Entry pass;

        public LoginPage()
        {
            InitializeComponent();

            StackLayout mainStack = new StackLayout();
            mainStack.Margin = 10;
            mainStack.VerticalOptions = LayoutOptions.CenterAndExpand;

            Label lab = new Label() { Text = "LOGIN", FontSize = 30, HorizontalTextAlignment = TextAlignment.Center };
            email = new Entry() { Placeholder = "Unesite vas email" };
            pass = new Entry() { Placeholder = "******", IsPassword = true };

            mainStack.Children.Add(lab);
            mainStack.Children.Add(email);
            mainStack.Children.Add(pass);

            StackLayout buttonStack = new StackLayout();
            buttonStack.Orientation = StackOrientation.Horizontal;
            buttonStack.HorizontalOptions = LayoutOptions.End;

            Button loginButton = new Button() { Text = "Login", VerticalOptions = LayoutOptions.Center };
            loginButton.Clicked += Login_Clicked;
            Button registrationButton = new Button() { Text = "Registracija", VerticalOptions = LayoutOptions.Center };
            registrationButton.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new RegistracijaPage());
            };

            buttonStack.Children.Add(loginButton);
            buttonStack.Children.Add(registrationButton);

            mainStack.Children.Add(buttonStack);
            Content = mainStack;
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            ApiService.Email = email.Text;
            ApiService.Sifra = pass.Text;
            try
            {
                var r = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email });
                if (r.Count == 1)
                {
                    await Navigation.PopToRootAsync();
                    await Navigation.PushAsync(new PocetniPage());
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}