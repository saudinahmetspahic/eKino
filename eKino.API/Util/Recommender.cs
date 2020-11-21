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
        public Recommender(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }   

        Dictionary<int, List<Ocijena>> filmovi = new Dictionary<int, List<Ocijena>>();


        public IEnumerable<Film> GetSlicneFilmove(int filmId)
        {
            UcitajFilmove(filmId);
            List<Ocijena> ocijenePosmatranogFilma = _context.Ocijena.Where(w => w.FilmId == filmId).OrderBy(o => o.KomentatorId).ToList();

            List<Ocijena> zajednickeOcijene1 = new List<Ocijena>();
            List<Ocijena> zajednickeOcijene2 = new List<Ocijena>();
            List<Film> preporuceniFilmovi = new List<Film>();

            foreach (var item in filmovi)
            {
                foreach (Ocijena o in ocijenePosmatranogFilma)
                {
                    if (item.Value.Where(w => w.KomentatorId == o.KomentatorId).Count() > 0)
                    {
                        zajednickeOcijene1.Add(o);
                        zajednickeOcijene2.Add(item.Value.Where(w => w.KomentatorId == o.KomentatorId).FirstOrDefault());
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcijene1, zajednickeOcijene2);
                if (slicnost > 0.5)
                    preporuceniFilmovi.Add(_context.Film.Where(w => w.Id == item.Key).FirstOrDefault());
                zajednickeOcijene1.Clear();
                zajednickeOcijene2.Clear();

            }

            return preporuceniFilmovi;
        }

        private double GetSlicnost(List<Ocijena> zajednickeOcijene1, List<Ocijena> zajednickeOcijene2)
        {
            if (zajednickeOcijene1.Count != zajednickeOcijene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcijene1.Count; i++)
            {
                brojnik += zajednickeOcijene1[i].DataOcijena * zajednickeOcijene2[i].DataOcijena;
                nazivnik1 += zajednickeOcijene1[i].DataOcijena * zajednickeOcijene1[i].DataOcijena;
                nazivnik2 += zajednickeOcijene2[i].DataOcijena * zajednickeOcijene2[i].DataOcijena;
            }

            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        private void UcitajFilmove(int filmId)
        {
            List<Film> aktivniFilmovi = _context.Film.Where(w => w.Id != filmId).ToList();
            List<Ocijena> ocijene;
            foreach (Film f in aktivniFilmovi)
            {
                ocijene = _context.Ocijena.Where(w => w.FilmId == f.Id).OrderBy(o => o.KomentatorId).ToList();
                if (ocijene.Count > 0)
                    filmovi.Add(f.Id, ocijene);

            }


        }

    }
}
