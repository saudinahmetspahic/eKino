using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Util
{
    public class Recommender
    {
        private readonly MojContext _context = null;
        private readonly IMapper _mapper = null;
        private bool NedovoljnoOcijena = false;
        public Recommender(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // Film         Korisnik
        // Dictionary<int, Dictionary<int, List<Ocijena>>> filmovi = new Dictionary<int, Dictionary<int, List<Ocijena>>>();
        public List<Film> Filmovi = new List<Film>();
        private List<Tuple<int, int, int>> Ocijene = new List<Tuple<int, int, int>>();

        public List<Film> GetPreporuceneFilmove(int korisnikId)
        {
            UcitajOcijene(korisnikId);

            if (Ocijene.Count() < 4 || NedovoljnoOcijena)
                return new List<Film>();

            List<Film> Filmovi = new List<Film>();
            List<Tuple<int, double>> Slicnosti = new List<Tuple<int, double>>();

            var k = Ocijene.Select(s => s.Item2).Distinct<int>().ToList();
            var ko = Ocijene.Where(w => w.Item2 == korisnikId);
            var o1 = ko.Where(w => w.Item2 == korisnikId).Select(s => s.Item3).ToList();
            for (int x = 0; x < k.Count(); x++)
            {
                var o2 = Ocijene.Where(w => w.Item2 == k[x]).Select(s => s.Item3).ToList();
                var slicnost = GetSlicnost(o1, o2, korisnikId, k[x]);
                if (slicnost >= 0.5)
                {
                    Slicnosti.Add(new Tuple<int, double>(k[x], slicnost));
                }
            }

            var korisnici = Slicnosti.Distinct().OrderByDescending(o => o.Item2).Select(s => s.Item1).ToList();
            foreach (var c in korisnici)
            {
                var cf = _context.Ocijena.Include(i => i.Film).Where(w => w.KomentatorId == c && w.DataOcijena == 5).Select(s => s.Film).ToList();
                foreach (var i in cf)
                {
                    Filmovi.Add(i);
                }
            }
            return Filmovi.Distinct<Film>().ToList();
        }


        private double GetSlicnost(List<int> zajednickeOcijene1, List<int> zajednickeOcijene2, int k1, int k2)
        {
            var proizvod = 0.0;
            var korjen1 = 0.0;
            var korjen2 = 0.0;
            var prosjek1 = zajednickeOcijene1.Average();
            var prosjek2 = zajednickeOcijene2.Average();

            for (int i = 0; i < zajednickeOcijene1.Count(); i++)
            {
                proizvod += (zajednickeOcijene1[i] - prosjek1) * (zajednickeOcijene2[i] - prosjek2);
                korjen1 += Math.Pow(zajednickeOcijene1[i] - prosjek1, 2);
                korjen2 += Math.Pow(zajednickeOcijene2[i] - prosjek2, 2);
            }

            korjen1 = Math.Sqrt(korjen1);
            korjen2 = Math.Sqrt(korjen2);

            var rezultat = proizvod / (korjen1 * korjen2);
            return rezultat;
        }

        private void UcitajOcijene(int korisnikId)
        {

            try
            {
                var ocijeneKorisnika = _context.Ocijena.Where(w => w.KomentatorId == korisnikId).Take(3).ToList();
                foreach (var o in ocijeneKorisnika)
                {
                    Ocijene.Add(new Tuple<int, int, int>(o.FilmId, korisnikId, o.DataOcijena));
                }

                var drugiKorisnici = _context.Ocijena.Where(w => w.KomentatorId != korisnikId && (w.FilmId == ocijeneKorisnika[0].FilmId || w.FilmId == ocijeneKorisnika[1].FilmId || w.FilmId == ocijeneKorisnika[2].FilmId)).OrderBy(o => o.KomentatorId).ToList();
                var K = drugiKorisnici.GroupBy(a => a.KomentatorId);
                foreach (var k in K)
                {
                    if (k.Count() == 3)
                    {
                        foreach (var x in k)
                        {
                            Ocijene.Add(new Tuple<int, int, int>(x.FilmId, x.KomentatorId, x.DataOcijena));
                        }
                    }
                }
                NedovoljnoOcijena = false;
            }
            catch (Exception e)
            {
                NedovoljnoOcijena = true;
            }

        }


    }
}
