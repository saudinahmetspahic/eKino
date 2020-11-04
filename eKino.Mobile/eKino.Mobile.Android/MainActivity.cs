using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using LibVLCSharp.Forms.Shared;
using PayPal.Forms;
using PayPal.Forms.Abstractions;

namespace eKino.Mobile.Droid
{
    [Activity(Label = "eKino.Mobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);

            LibVLCSharpFormsRenderer.Init();

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var config = new PayPalConfiguration(PayPalEnvironment.NoNetwork, "AeQ87rcFB6R-vIzWr0oGlHPEjzcauiS8_jl4NgmThKk-vaoEwz0seUoPIwVeyWNMTpBpTv_OHHuh8Nn_")
            {
                //If you want to accept credit cards
                AcceptCreditCards = true,
                //Your business name
                MerchantName = "eKino",
                //Your privacy policy Url
                MerchantPrivacyPolicyUri = "https://www.example.com/privacy",
                //Your user agreement Url
                MerchantUserAgreementUri = "https://www.example.com/legal",
                // OPTIONAL - ShippingAddressOption (Both, None, PayPal, Provided)
                ShippingAddressOption = ShippingAddressOption.Both,
                // OPTIONAL - Language: Default languege for PayPal Plug-In
                Language = "es",
                // OPTIONAL - PhoneCountryCode: Default phone country code for PayPal Plug-In
                PhoneCountryCode = "52",
            };
            //Android
            CrossPayPalManager.Init(config, this);

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}