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
        public KorisnikService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void Add(Model.Korisnik korisnik)
        {
            _context.Korisnik.Add(_mapper.Map<Korisnik>(korisnik));
            _context.SaveChanges();
        }

        public IEnumerable<Model.Korisnik> Get()
        {
            return _mapper.Map<IEnumerable<Model.Korisnik>>(_context.Korisnik.ToList());
        }

        public Model.Korisnik GetById(int id)
        {
            return _mapper.Map<Model.Korisnik>(_context.Korisnik.SingleOrDefault(w => w.Id == id));
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

        public Model.Korisnik Update(int id, Model.Korisnik korisnik)
        {
            var k = _context.Korisnik.SingleOrDefault(w => w.Id == id);
            if(k != null)
            {
                k = _mapper.Map<Database.Korisnik>(korisnik);                
                _context.SaveChanges();
                return _mapper.Map<Model.Korisnik>(k);
            }
            return korisnik;
        }
    }
}
