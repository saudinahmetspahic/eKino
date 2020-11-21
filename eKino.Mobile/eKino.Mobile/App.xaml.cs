using Xamarin.Forms;
using eKino.Mobile.Services;
using eKino.Mobile.Views;
using Android.App;

namespace eKino.Mobile
{
    public partial class App : Xamarin.Forms.Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {      
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
