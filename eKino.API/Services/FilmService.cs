using AutoMapper;
using eKino.API.EF;
using eKino.Model;
//using eKino.API.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model.Requests;
using eKino.API.Util;

namespace eKino.API.Services
{
    public class FilmService
        :
        BaseCRUDService<Model.Film, FilmSearchRequest, Database.Film, FilmInsertRequest, FilmInsertRequest>,
        IFilmService
    {
        public FilmService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Film> Get(FilmSearchRequest search)
        {
            var query = _context.Film.AsQueryable();

            if(search.Id > 0)
            {
                query = query.Where(w => w.Id == search.Id);
            }
            if (!string.IsNullOrEmpty(search.Naziv))
            {
                query = query.Where(w => w.Naziv == search.Naziv);
            }
       
            return _mapper.Map<List<Model.Film>>(query.ToList());
        }


        public IEnumerable<Film> GetPreporuceneFilmove(int korisnikId)
        {
            var r = new Recommender(_context, _mapper);
            return _mapper.Map<IEnumerable<Model.Film>>(r.GetPreporuceneFilmove(korisnikId));
        }


    }
}
