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

namespace eKino.API.Services
{
    public class FilmService 
        : 
        BaseCRUDService<Model.Film, FilmSearchRequest, Database.Film, FilmInsertRequest, FilmInsertRequest>,
        IFilmService
    {
        //private readonly MojContext _context = null;
        //private IMapper _mapper = null;
        public FilmService(MojContext context, IMapper mapper) : base(context, mapper)
        {
            //_context = context;
            //_mapper = mapper;
        }

        //public IEnumerable<Model.Film> Get()
        //{
           
        //    return _mapper.Map<IEnumerable<Film>>(_context.Film.ToList());
        //}

        public IEnumerable<Model.Film> GetByNaziv(string naziv)
        {
            return _mapper.Map<IEnumerable<Model.Film>>(_context.Film.Where(w => w.Naziv == naziv));
        }

        public IEnumerable<Film> GetByZanr(string zanr)
        {
            var zanrID = _context.Zanr.Where(w => w.NazivZanra == zanr).Select(s => s.Id).SingleOrDefault();
            return _mapper.Map<IEnumerable<Model.Film>>(_context.Film.Where(w => w.ZanrId == zanrID));
        }

        //public Model.Film GetById(int id)
        //{
        //    return _mapper.Map<Model.Film>(_context.Film.SingleOrDefault(w => w.Id == id));
        //}

        //public bool Remove(int id)
        //{
        //    var film = _context.Film.SingleOrDefault(w => w.Id == id);
        //    if (film != null)
        //    {
        //        _context.Film.Remove(film);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        //public void Add(Model.Film film)
        //{          
        //    _context.Film.Add(_mapper.Map<Database.Film>(film));
        //    _context.SaveChanges();
        //}

        //public Model.Film Update(int id, FilmInsertRequest film)
        //{
        //    var entity = _mapper.Map<Database.Film>(film);
        //    entity.Id = id;
        //    _context.Film.Update(entity);
        //    _context.SaveChanges();
        //    return _mapper.Map<Model.Film>(entity);
        //}

       
    }
}
