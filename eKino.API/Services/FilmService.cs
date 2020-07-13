using AutoMapper;
using eKino.API.EF;
using eKino.Model;
//using eKino.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class FilmService : IFilmService
    {
        private readonly MojContext _context = null;
        private IMapper _mapper = null;
        public FilmService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Film> Get()
        {
           
            return _mapper.Map<IEnumerable<Film>>(_context.Film.ToList());
        }

        public Film GetById(int id)
        {
            return _mapper.Map<Film>(_context.Film.SingleOrDefault(w => w.Id == id));
        }

        public bool Remove(int id)
        {
            var film = _context.Film.SingleOrDefault(w => w.Id == id);
            if (film != null)
            {
                _context.Film.Remove(film);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void Add(Film film)
        {
            _context.Film.Add(_mapper.Map<Models.Film>(film));
            _context.SaveChanges();
        }

        public Film Update(int id, Film film)
        {
            var f = _mapper.Map<Film>(_context.Film.SingleOrDefault(w => w.Id == id));
            f = film;
            _context.Film.Update(_mapper.Map<Models.Film>(f));
            _context.SaveChanges();
            return f;
        }
    }
}
