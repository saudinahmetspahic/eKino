using Xamarin.Forms;
using eKino.Mobile.Services;
using eKino.Mobile.Views;

namespace eKino.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
