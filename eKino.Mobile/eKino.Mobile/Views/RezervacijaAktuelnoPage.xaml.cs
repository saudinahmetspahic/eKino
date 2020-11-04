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
    public partial class ProjekcijaAktuelnoPage : ContentPage
    {
        private RezervacijaAktuelnoViewModel model;
        private bool _a = true;
        private bool _n = true;
        public ProjekcijaAktuelnoPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaAktuelnoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init(true, true);
            PopuniTabelu();
        }

        private void Aktivne_Clicked(object sender, EventArgs e)
        {
            _a = !_a;
            if (_a)
                AButton.BackgroundColor = Color.Green;
            else
                AButton.BackgroundColor = Color.LightGreen;
            model.Init(_a, _n);
            PopuniTabelu();
        }

        private void Neaktivne_Clicked(object sender, EventArgs e)
        {
            _n = !_n;
            if (_n)
                NButton.BackgroundColor = Color.Green;
            else
                NButton.BackgroundColor = Color.LightGreen;
            model.Init(_a, _n);
            PopuniTabelu();
        }

        private void PopuniTabelu()
        { 
            while (mainGrid.Children.Count() > 0)
            {
                mainGrid.Children.Remove(mainGrid.Children.First());
            }

            var c = model.RezervacijeZaIspis.Count();
            mainGrid.RowDefinitions = new RowDefinitionCollection();
            for (int i = 0; i < c; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition { Height = 50 });
                mainGrid.RowDefinitions.Add(new RowDefinition { Height = 30 });
                mainGrid.RowDefinitions.Add(new RowDefinition { Height = 30 });
                mainGrid.RowDefinitions.Add(new RowDefinition { Height = 30 });
            }

            int row = 0;
            foreach (var r in model.RezervacijeZaIspis)
            {
                var naslov = new Label { Margin = new Thickness(5, 5), Text = " 🎥 " + r.RedniBroj + ".  " + r.Film, FontAttributes = FontAttributes.Bold, FontSize = 18, BackgroundColor = Color.SpringGreen, TextColor = Color.White, VerticalTextAlignment = TextAlignment.Center };
                var datumRezervacije = new Label { Margin = new Thickness(10, 2), Text = "Rezervisano " + r.DatumRezervacije };
                var info = new Label { Margin = new Thickness(10, 2), Text = "Projekcija " + r.DatumProjekcije + ", dvorana " + r.Dvorana + " (sjedište " + r.Sjediste + ")" };
                var cijena = new Label { Margin = new Thickness(10, 2), Text = "Cijena " + r.Cijena + " KM" };

                mainGrid.Children.Add(naslov, 0, row); row++;
                mainGrid.Children.Add(datumRezervacije, 0, row); row++;
                mainGrid.Children.Add(info, 0, row); row++;
                mainGrid.Children.Add(cijena, 0, row); row++;
            }
        }
    }
}