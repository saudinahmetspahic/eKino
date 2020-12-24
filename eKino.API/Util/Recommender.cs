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
        public List<Ocijena> OcijeneKorisnika = new List<Ocijena>();
        public List<Film> Filmovi = new List<Film>();
        private List<Tuple<int, int, int>> Ocijene = new List<Tuple<int, int, int>>();

        public List<Film> GetPreporuceneFilmove(int korisnikId)
        {
            UcitajOcijene(korisnikId);

            if (Ocijene.Count() < 4 || NedovoljnoOcijena)
                return new List<Film>();

            var nfs = _context.Ocijena.Where(w => w.KomentatorId != korisnikId).ToList();
            var nf = nfs.Where(w => OcijeneKorisnika.Where(W => W.FilmId == w.FilmId).Count() == 0).GroupBy(g => g.FilmId);

            foreach (var n in nf)
            {
                var brojnik = 0.0;
                var kolicnik = 0.0;

                var o1 = Ocijene.Where(w => w.Item2 == korisnikId).Select(s => s.Item3).ToList();
                foreach (var x in n)
                {
                    var o2 = Ocijene.Where(w => w.Item2 == x.KomentatorId).Select(s => s.Item3).ToList();
                    var slicnost = GetSlicnost(o1, o2, korisnikId, x.KomentatorId);

                    brojnik += slicnost * (x.DataOcijena - o2.Average());
                    kolicnik += slicnost;
                }

                var predikcija = (brojnik / kolicnik) + o1.Average();

                if (predikcija >= 4)
                    Filmovi.Add(_context.Film.Find(n.Select(s => s.FilmId).FirstOrDefault()));
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
                OcijeneKorisnika = _context.Ocijena.Where(w => w.KomentatorId == korisnikId).Take(3).OrderBy(o => o.FilmId).ToList();
                foreach (var o in OcijeneKorisnika)
                {
                    Ocijene.Add(new Tuple<int, int, int>(o.FilmId, korisnikId, o.DataOcijena));
                }

                var drugiKorisnici = _context.Ocijena.Where(w => w.KomentatorId != korisnikId && (w.FilmId == OcijeneKorisnika[0].FilmId || w.FilmId == OcijeneKorisnika[1].FilmId || w.FilmId == OcijeneKorisnika[2].FilmId)).OrderBy(o => o.KomentatorId).ThenBy(o => o.FilmId).ToList();
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
