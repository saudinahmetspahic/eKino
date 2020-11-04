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

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijaDodajPage : ContentPage
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _korisnikPaketService = new ApiService("KorisnikPaket");
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly ApiService _rezervacijaService = new ApiService("Rezervacija");
        private RezervacijaDodajViewModel model;
        private List<Tuple<int, int>> MjestaZaRezervisati = new List<Tuple<int, int>>();
        private Korisnik _korisnik;

        public RezervacijaDodajPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaDodajViewModel();
            _korisnik = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private void PickerPromjenaProjekcije(object sender, EventArgs e)
        {
            MjestaZaRezervisati.Clear();
            model.Init();
            PopuniGrid();
            UpdateInfoText();
        }

        private void Ponisti_Clicked(object sender, EventArgs e)
        {
            MjestaZaRezervisati.Clear();
            PopuniGrid();
            UpdateInfoText();
        }

        private void Dodaj_Clicked(object sender, EventArgs e)
        {
            foreach (var m in MjestaZaRezervisati)
            {
                var r = m.Item1;
                var k = m.Item2;
                _rezervacijaService.Add(new RezervacijaInsertRequest
                {
                    DatumKreirnja = DateTime.Now,
                    KupacId = _korisnik.Id,
                    ProjekcijaId = model.OdabranaProjekcija.Id,
                    SjedisteKolona = k,
                    SjedisteRed = r
                });
                Navigation.PopAsync();
            }
        }


        private void PopuniGrid()
        {
            var dvorana = model.OdabranaDvorana;
            var r = dvorana.BrojRedova;
            var k = dvorana.BrojKolona;

            var ch = OutsideGrid.Children.Where(w => w.GetType().Name == "Grid").ToList();
            while (ch.Count() > 0)
            {
                OutsideGrid.Children.Remove(ch.First());
                ch.Remove(ch.First());
            }

            var mainGrid = new Grid();
            mainGrid.RowDefinitions = new RowDefinitionCollection { new RowDefinition() };
            mainGrid.ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition() };


            var gridRedovi = new Grid();
            gridRedovi.RowDefinitions = new RowDefinitionCollection();
            for (int i = 0; i < r; i++)
            {
                gridRedovi.RowDefinitions.Add(new RowDefinition());
                var label = new Label { Text = (Char.ConvertFromUtf32(i + 65)).ToString(), VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.Center, FontAttributes = FontAttributes.Bold };
                gridRedovi.Children.Add(label, 0, i);
            }

            var gridKolone = new Grid();
            gridKolone.ColumnDefinitions = new ColumnDefinitionCollection();
            for (int i = 0; i < k; i++)
            {
                gridKolone.ColumnDefinitions.Add(new ColumnDefinition());
                var label = new Label { Text = i.ToString(), VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.Center, FontAttributes = FontAttributes.Bold };
                gridKolone.Children.Add(label, i, 0);
            }

            var gridSjedista = new Grid();
            gridSjedista.ColumnDefinitions = new ColumnDefinitionCollection();
            gridSjedista.RowDefinitions = new RowDefinitionCollection();
            for (int i = 0; i < r; i++)
            {
                gridSjedista.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < k; i++)
            {
                gridSjedista.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    var label = new Label { TextColor = Color.Red, VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.Center, FontAttributes = FontAttributes.Bold };
                    if (model.ZauzetaSjedista.Where(w => w.Item2 == i && w.Item3 == j).Count() > 0)
                        label.Text = "⬤";
                    else
                        label.Text = "〇";
                    label.AutomationId = i + "/" + j;

                    var tapR = new TapGestureRecognizer();
                    tapR.Tapped += (sender, e) =>
                    {
                        var ss = ((Label)sender).AutomationId.Split('/');
                        var item = new Tuple<int, int>(int.Parse(ss[0]), int.Parse(ss[1]));
                        if (MjestaZaRezervisati.Contains(item) == true)
                        {
                            MjestaZaRezervisati.Remove(item);
                            label.Text = "〇";
                        }
                        else if (model.ZauzetaSjedista.Where(w => w.Item2 == item.Item1 && w.Item3 == item.Item2).Count() > 0)
                        {
                            if (model.ZauzetaSjedista.Where(w => w.Item2 == item.Item1 && w.Item3 == item.Item2).Select(s => s.Item1).FirstOrDefault() == _korisnik.Id)
                            {
                                var rez = _rezervacijaService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = _korisnik.Id, ProjekcijaId = model.OdabranaProjekcija.Id });
                                var rezId = rez.Where(w => w.SjedisteRed == item.Item1 && w.SjedisteKolona == item.Item2).Select(s => s.Id).FirstOrDefault();
                                _rezervacijaService.Remove(rezId);
                                var c = model.ZauzetaSjedista.Where(w => w.Item2 == item.Item1 && w.Item3 == item.Item2).FirstOrDefault();
                                model.ZauzetaSjedista.Remove(c);
                                ((Label)sender).Text = "〇";
                            }
                            else return; // neko drugi je rezervisao odabrano sjedište
                        }
                        else
                        {
                            MjestaZaRezervisati.Add(item);
                            label.Text = "⬤";
                        }
                        UpdateInfoText();
                    };
                    label.GestureRecognizers.Add(tapR);
                    gridSjedista.Children.Add(label, j, i);
                }
            }

            OutsideGrid.Children.Add(gridRedovi, 0, 1);
            OutsideGrid.Children.Add(mainGrid, 1, 1);
            mainGrid.Children.Add(gridSjedista);
            OutsideGrid.Children.Add(gridKolone, 1, 2);
            OutsideGrid.IsVisible = true;
        }

        private void UpdateInfoText()
        {
            var zauzetaMjesta = model.ZauzetaSjedista.Where(w => w.Item1 == _korisnik.Id).Count();
            BrojRezervacijaText.Text = (MjestaZaRezervisati.Count() + zauzetaMjesta).ToString();
            var cijena = model.OdabranaProjekcija.CijenaUlaznice;
            var ukupnaCijena = ((MjestaZaRezervisati.Count() + zauzetaMjesta) * cijena);

            var _korisnikPaket = _korisnikPaketService.Get<List<KorisnikPaket>>(new KorisnikPaketSearchRequest { KorisnikId = _korisnik.Id }).FirstOrDefault();

            if (_korisnikPaket != null)
            {
                var paket = _paketService.GetById<Paket>(_korisnikPaket.PaketId);
                ukupnaCijena -= (double)(paket.Cijena * 0.1);
                if (ukupnaCijena < 0)
                    ukupnaCijena = 0;
            }
            UkupnaCijenaText.Text = ukupnaCijena.ToString();
        }
    }
}