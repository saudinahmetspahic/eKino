using eKino.Mobile.ViewModels;
using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReakcijaTip = eKino.Model.Requests.ReakcijaTip;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmDetaljiPage : ContentPage
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _ocijenaService = new ApiService("Ocijena");
        private readonly ApiService _komentarReakcijaService = new ApiService("KomentarReakcija");
        private readonly ApiService _komentarService = new ApiService("Komentar");
        private readonly ApiService _korisnikPaketService = new ApiService("KorisnikPaket");
        private readonly ApiService _paketService = new ApiService("Paket");
        private FilmDetaljiViewModel model;
        private Korisnik _korisnik;
        private int _filmId;
        public FilmDetaljiPage(int filmId)
        {
            InitializeComponent();
            BindingContext = model = new FilmDetaljiViewModel(filmId);
            _filmId = filmId;
            _korisnik = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
            PrikaziDetalje();
            listViewPreporuka.ItemsSource = model.PreporuceniFilmoviList;
        }



        private void PrikaziDetalje()
        {
            var row = 0;
            var glumci = model.Glumci;
            GlumciGrid.RowDefinitions = new RowDefinitionCollection();
            foreach (var g in glumci)
            {
                GlumciGrid.RowDefinitions.Add(new RowDefinition { Height = 25 });
                var label = new Label { Text = g };
                GlumciGrid.Children.Add(label, 0, row); row++;
            }

            row = 0;
            var scenaristi = model.Scenaristi;
            ScenaristiGrid.RowDefinitions = new RowDefinitionCollection();
            foreach (var s in scenaristi)
            {
                ScenaristiGrid.RowDefinitions.Add(new RowDefinition { Height = 25 });
                var label = new Label { Text = s };
                ScenaristiGrid.Children.Add(label, 0, row); row++;
            }

            row = 0;
            var prKuce = model.PrKuce;
            PrKuceGrid.RowDefinitions = new RowDefinitionCollection();
            foreach (var k in prKuce)
            {
                PrKuceGrid.RowDefinitions.Add(new RowDefinition { Height = 25 });
                var label = new Label { Text = k };
                PrKuceGrid.Children.Add(label, 0, row); row++;
            }

            var ocijena = model.Ocijena;
            for (int i = 0; i < 5; i++)
            {
                var label = new Label();
                label.AutomationId = (i + 1).ToString();
                if (i + 1 <= ocijena)
                    label.Text = "★";
                else
                    label.Text = "☆";
                label.FontAttributes = FontAttributes.Bold;
                label.FontSize = 20;
                label.HorizontalTextAlignment = TextAlignment.Center;

                var tapR = new TapGestureRecognizer();
                tapR.Tapped += (sender, e) =>
                {
                    OcijeniFilm(int.Parse(((Label)sender).AutomationId));
                };
                label.GestureRecognizers.Add(tapR);
                OcijeneGrid.Children.Add(label, i, 0);
            }


            KomentariGrid.RowDefinitions = new RowDefinitionCollection();
            var komentari = model.Komentari;
            for (int i = 0; i < (komentari.Count() > 15 ? 15 : komentari.Count()); i++)
            {
                KomentariGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                var ime = new Label { Text = komentari[i].Item2, FontAttributes = FontAttributes.Bold };

                var kom = new Label { Text = komentari[i].Item3, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };

                var grid = new Grid();
                grid.ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition { Width = 70 } };
                grid.RowDefinitions = new RowDefinitionCollection { new RowDefinition { Height = 25 }, new RowDefinition { Height = 25 } };

                var likes = new Label { Text = "👍 " + komentari[i].Item4.ToString(), AutomationId = komentari[i].Item1.ToString() };
                var dislikes = new Label { Text = "👎 " + komentari[i].Item5.ToString(), AutomationId = komentari[i].Item1.ToString() };

                var tapLR = new TapGestureRecognizer();
                tapLR.Tapped += (sender, e) =>
                {
                    DodajReakciju((Label)sender, ReakcijaTip.Like);
                };
                likes.GestureRecognizers.Add(tapLR);

                var tapDR = new TapGestureRecognizer();
                tapDR.Tapped += (sender, e) =>
                {
                    DodajReakciju((Label)sender, ReakcijaTip.Dislike);
                };
                dislikes.GestureRecognizers.Add(tapDR);

                grid.Children.Add(likes, 0, 0);
                grid.Children.Add(dislikes, 0, 1);

                KomentariGrid.Children.Add(ime, 0, i);
                KomentariGrid.Children.Add(kom, 1, i);
                KomentariGrid.Children.Add(grid, 3, i);
            }
        }

        private void DodajReakciju(Label lab, ReakcijaTip tip)
        {
            if (_komentarReakcijaService.Get<List<KomentarReakcija>>(new KomentarReakcijaSearchRequest { KorisnikId = _korisnik.Id, KomentarId = int.Parse(lab.AutomationId) }).Count() > 0)
                return;

            _komentarReakcijaService.Add(new KomentarReakcijaInsertRequest
            {
                KomentarId = int.Parse(lab.AutomationId),
                KorisnikId = _korisnik.Id,
                Reakcija = tip
            });

            var t = lab.Text.Split(' ');
            var r = int.Parse(t[1]);
            lab.Text = t[0] + " " + (r + 1);
        }

        private void OcijeniFilm(int ocijena)
        {
            if (_ocijenaService.Get<List<Ocijena>>(new OcijenaSearchRequest { FilmId = _filmId, KorisnikId = _korisnik.Id }).Count() > 0)
                return;
            _ocijenaService.Add(new OcijenaInsertRequest
            {
                DataOcijena = ocijena,
                FilmId = _filmId,
                KomentatorId = _korisnik.Id,
            });
            Application.Current.MainPage.DisplayAlert("Potvrda", "Uspiješno ste dodijelili vašu ocijenu odabranom filmu.", "Ok");
        }

        private void DodajKomentar_Clicked(object sender, EventArgs e)
        {
            var text = KomentarText.Text;
            if (string.IsNullOrEmpty(text))
                return;

            _komentarService.Add(new KomentarInsertRequest
            {
                FilmId = _filmId,
                KomentatorId = _korisnik.Id,
                SadrzajKomentara = text
            });
            KomentarText.Text = string.Empty;
            Application.Current.MainPage.DisplayAlert("Potvrda", "Vaš komentar je uspiješno dodan.", "Ok");
        }

        private void GledajFilm_Clicked(object sender, EventArgs e)
        {
            var kpaket = _korisnikPaketService.Get<List<KorisnikPaket>>(new KorisnikPaketSearchRequest { KorisnikId = _korisnik.Id }).FirstOrDefault();
            var paket = _paketService.GetById<Paket>(kpaket.PaketId);
            if (paket != null)
            {
                if (paket.MaxOcijena >= model.Ocijena && paket.DatumIsteka.Value.CompareTo(DateTime.Now) > 0)
                    Navigation.PushAsync(new FilmGeldajPage(model.Link));
                else Application.Current.MainPage.DisplayAlert("Paket", "Vas paket je istekao ili nije dovoljan za gledanje ovog filma", "Ok");
            }
            else Application.Current.MainPage.DisplayAlert("Paket", "Nemate potrebni paket za gledanje ovog filma.", "Ok");
        }

        private void ImageCell_Tapped(object sender, EventArgs e)
        {
            var fId = int.Parse(((ImageCell)sender).AutomationId);
            Navigation.PushAsync(new FilmDetaljiPage(fId));
        }

        private void Prijavi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilmPrijavi(model, _filmId));
        }
    }
}