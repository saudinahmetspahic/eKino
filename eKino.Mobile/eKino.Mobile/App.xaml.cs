using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eKino.Mobile.Services;
using eKino.Mobile.Views;
using Octane.Xamarin.Forms.VideoPlayer;
using Octane.Xamarin.Forms.VideoPlayer.Constants;
using System.Reflection;

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
            VideoPlayer v = new VideoPlayer($"C:\\Users\\A1\\Desktop\\CC_1916_10_02_ThePawnshop_512kb.mp4", true);
            if(v.State == PlayerState.Prepared)
                v.Play();

               
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
