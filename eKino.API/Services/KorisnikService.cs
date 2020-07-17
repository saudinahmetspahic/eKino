using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class KorisnikService : IKorisnikService
    {
        private readonly MojContext _context = null;
        private readonly IMapper _mapper = null;
        KorisnikService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void Add(Korisnik korisnik)
        {
            _context.Korisnik.Add(korisnik);
        }

        public IEnumerable<Korisnik> Get()
        {
            return _context.Korisnik.ToList();
        }

        public Korisnik GetById(int id)
        {
            return _context.Korisnik.SingleOrDefault(w => w.Id == id);
        }

        public Model.Korisnik GetByIme(string ime)
        {
            return _mapper.Map<Model.Korisnik>(_context.Korisnik.SingleOrDefault(w => w.Ime == ime));
        }

        public bool Remove(int id)
        {
            var korisnik = _context.Korisnik.SingleOrDefault(w => w.Id == id);
            if(korisnik != null)
            {
                _context.Korisnik.Remove(korisnik);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Korisnik Update(int id, Korisnik korisnik)
        {
            var k = _context.Korisnik.SingleOrDefault(w => w.Id == id);
            if(k != null)
            {
                k = korisnik;                
                _context.SaveChanges();
                return k;
            }
            return korisnik;
        }
    }
}
