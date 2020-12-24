using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class FilmDetaljiViewModel : BaseViewModel
    {
        private readonly ApiService _preporukafilmService;
        private readonly ApiService _filmService = new ApiService("Film");
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _osobeService = new ApiService("Osoba");
        private readonly ApiService _zanrService = new ApiService("Zanr");
        private readonly ApiService _tipService = new ApiService("Tip");
        private readonly ApiService _projekcijaService = new ApiService("Projekcija");
        private readonly ApiService _filmglumciService = new ApiService("FilmGlumci");
        private readonly ApiService _filmscenaristiService = new ApiService("FilmScenaristi");
        private readonly ApiService _filmprkuceService = new ApiService("FilmProdukcijskeKuce");
        private readonly ApiService _prkucaService = new ApiService("ProdukcijskaKuca");
        private readonly ApiService _ocijenaService = new ApiService("Ocijena");
        private readonly ApiService _komentarService = new ApiService("Komentar");
        private readonly ApiService _komentarReakcijaService = new ApiService("KomentarReakcija");
        private ICommand InitCommand;
        private Film Film;
        public FilmDetaljiViewModel()
        {
        }
        public FilmDetaljiViewModel(int filmId = 0)
        {
            Film = _filmService.GetById<Film>(filmId);
            var k = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            _preporukafilmService = new ApiService("Film/RecommendedFilmovi/" + k.Id);
            InitCommand = new Command(() => { Init(); });
        }
        public void Init()
        {
            Image = ImageConvertor.ConvertByteArrayToImageForXamarin(Film.Slika);
            NazivFilma = Film.Naziv;
            Zanr = _zanrService.GetById<Zanr>(Film.ZanrId).NazivZanra;
            Tip = _tipService.GetById<Tip>(Film.TipId).NazivTipa;
            DatumIzlaska = Film.DatumIzlaska.ToString("dd/MM/yyyy");
            Opis = Film.Opis;
            Projekcija = _projekcijaService.Get<List<Projekcija>>().Where(w => w.FilmId == Film.Id).Select(s => s.Opis).FirstOrDefault();

            var glumciId = _filmglumciService.Get<List<FilmGlumci>>(new FilmGlumciSearchRequest { FilmId = Film.Id }).Select(s => s.GlumacId);
            foreach (var gId in glumciId)
            {
                var glumac = _osobeService.GetById<Osoba>(gId);
                Glumci.Add(glumac.Ime + " " + glumac.Prezime);
            }

            var scenaristiId = _filmscenaristiService.Get<List<FilmScenaristi>>(new FilmScenaristiSearchRequest { FilmId = Film.Id }).Select(s => s.ScenaristId);
            foreach (var sId in scenaristiId)
            {
                var scenarist = _osobeService.GetById<Osoba>(sId);
                Scenaristi.Add(scenarist.Ime + " " + scenarist.Prezime);
            }

            var produkcijskeKuceId = _filmprkuceService.Get<List<FilmProdukcijskeKuce>>(new FilmProdukcijskeKuceSearchRequest { FilmId = Film.Id }).Select(s => s.ProdukcijskaKucaId);
            foreach (var pkId in produkcijskeKuceId)
            {
                var prKuca = _prkucaService.GetById<ProdukcijskaKuca>(pkId);
                PrKuce.Add(prKuca.Naziv);
            }

            var ocijene = _ocijenaService.Get<List<Ocijena>>(new OcijenaSearchRequest { FilmId = Film.Id });
            Ocijena = (int)(ocijene.Average(a => (int?)a.DataOcijena) ?? 0);

            var komentari = _komentarService.Get<List<Komentar>>(new KomentarSearchRequest { FilmId = Film.Id });
            foreach (var k in komentari)
            {
                var komentator = _korisnikService.GetById<Korisnik>(k.KomentatorId);
                var reakcije = _komentarReakcijaService.Get<List<KomentarReakcija>>(new KomentarReakcijaSearchRequest { KomentarId = k.Id });
                var likes = reakcije.Where(w => w.Reakcija == Model.ReakcijaTip.Like).Count();
                var dislikes = reakcije.Where(w => w.Reakcija == Model.ReakcijaTip.Dislike).Count();
                Komentari.Add(new Tuple<int, string, string, int, int>(k.Id, komentator.Ime + " " + komentator.Prezime, k.SadrzajKomentara, likes, dislikes));
            }

            Link = Film.Link;

            //sistem preporuke
            var preporuceniFilmovi = _preporukafilmService.Get<List<Film>>();
            for (int i = 0; i < (preporuceniFilmovi.Count > 5 ? 5 : preporuceniFilmovi.Count); i++)
            {
                PreporuceniFilmoviList.Add(new PreporuceniFilmovi
                {
                    FilmId = preporuceniFilmovi[i].Id,
                    NazivFilma = preporuceniFilmovi[i].Naziv,
                    Opis = preporuceniFilmovi[i].Opis,
                    Slika = ImageConvertor.ConvertByteArrayToImageForXamarin(preporuceniFilmovi[i].Slika)
                });
            }
        }

        public List<PreporuceniFilmovi> PreporuceniFilmoviList { get; set; } = new List<PreporuceniFilmovi>();

        private string _link;
        public string Link
        {
            get { return _link; }
            set { SetProperty(ref _link, value); }
        }

        private ImageSource _image;
        public ImageSource Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }
        private string _nazivFilma;
        public string NazivFilma
        {
            get { return _nazivFilma; }
            set { SetProperty(ref _nazivFilma, value); }
        }
        private string _zanr;
        public string Zanr
        {
            get { return _zanr; }
            set { SetProperty(ref _zanr, value); }
        }
        private string _tip;
        public string Tip
        {
            get { return _tip; }
            set { SetProperty(ref _tip, value); }
        }
        private string _datumIzlaska;
        public string DatumIzlaska
        {
            get { return _datumIzlaska; }
            set { SetProperty(ref _datumIzlaska, value); }
        }
        private List<string> _glumci = new List<string>();
        public List<string> Glumci
        {
            get { return _glumci; }
            set { SetProperty(ref _glumci, value); }
        }
        private List<string> _scenaristi = new List<string>();
        public List<string> Scenaristi
        {
            get { return _scenaristi; }
            set { SetProperty(ref _scenaristi, value); }
        }
        private List<string> _prKuce = new List<string>();
        public List<string> PrKuce
        {
            get { return _prKuce; }
            set { SetProperty(ref _prKuce, value); }
        }
        private string _projekcija;
        public string Projekcija
        {
            get { return _projekcija; }
            set { SetProperty(ref _projekcija, value); }
        }
        private string _opis;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }
        private int _ocijena;
        public int Ocijena
        {
            get { return _ocijena; }
            set { SetProperty(ref _ocijena, value); }
        }
        private List<Tuple<int, string, string, int, int>> _komentari = new List<Tuple<int, string, string, int, int>>(); // komentarId, komentar, osoba, likes, dislikes
        public List<Tuple<int, string, string, int, int>> Komentari
        {
            get { return _komentari; }
            set { SetProperty(ref _komentari, value); }
        }
    }
}
