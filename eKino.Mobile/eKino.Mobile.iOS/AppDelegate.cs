using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using PayPal.Forms;
using PayPal.Forms.Abstractions;
using UIKit;

namespace eKino.Mobile.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            var config = new PayPalConfiguration(PayPalEnvironment.NoNetwork, "AeQ87rcFB6R-vIzWr0oGlHPEjzcauiS8_jl4NgmThKk-vaoEwz0seUoPIwVeyWNMTpBpTv_OHHuh8Nn_")
            {
                //If you want to accept credit cards
                AcceptCreditCards = true,
                //Your business name
                MerchantName = "Test Store",
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
            //iOS
            CrossPayPalManager.Init(config);


            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
