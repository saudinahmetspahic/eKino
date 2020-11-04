using eKino.Mobile.ViewModels;
using eKino.Model;
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
    public partial class FilmAktuelnoPage : ContentPage
    {
        private FilmAktuelnoViewModel model;
        public FilmAktuelnoPage()
        {
            InitializeComponent();
            BindingContext = model = new FilmAktuelnoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
            PrikaziFilmove();
        }

        private void PrikaziFilmove(int stranica = 1)
        {

            for (int i = (stranica * 10) - 10, row = 0; i < stranica * 10; i++, row++)
            {
                var film = model.FilmoviList[i];
                var grid = new Grid();
                grid.AutomationId = film.Id.ToString();
                grid.ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition() };
                grid.RowDefinitions = new RowDefinitionCollection { new RowDefinition { Height = 150 }, new RowDefinition { Height = 20 }, new RowDefinition { Height = 20 }, new RowDefinition { Height = 20 } };

                var img = new Image { Source = ImageConvertor.ConvertByteArrayToImageForXamarin(film.Slika), HeightRequest = 150, WidthRequest = 150, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };
                var imeFilma = new Label { TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center, HorizontalTextAlignment = TextAlignment.Center, Text = "Naziv: " + film.Naziv, FontSize = 15 };
                var zanrFilma = new Label { FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center, HorizontalTextAlignment = TextAlignment.Center, Text = "Žanr: " + model.ZanroviList.Where(w => w.Id == film.ZanrId).Select(s => s.NazivZanra).FirstOrDefault(), FontSize = 14 };
                var tipFilma = new Label { FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center, HorizontalTextAlignment = TextAlignment.Center, Text = "Tip: " + model.TipoviList.Where(w => w.Id == film.TipId).Select(s => s.NazivTipa).FirstOrDefault(), FontSize = 14 };

                grid.Children.Add(img, 0, 0);
                grid.Children.Add(imeFilma, 0, 1);
                grid.Children.Add(zanrFilma, 0, 2);
                grid.Children.Add(tipFilma, 0, 3);

                var tapR = new TapGestureRecognizer();
                tapR.Tapped += (sender, e) => {
                    Navigation.PushAsync(new FilmDetaljiPage(int.Parse(((Grid)sender).AutomationId)));
                };
                grid.GestureRecognizers.Add(tapR);

                filmoviGrid.Children.Add(grid, 0, row);
            }
        }

    }
}