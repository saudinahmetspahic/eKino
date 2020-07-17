using eKino.API.Database;
using eKino.API.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class GradService : IGradService
    {
        private readonly MojContext _context = null;
        public GradService(MojContext context)
        {
            _context = context;
        }

        public void Add(Grad grad)
        {
            _context.Grad.Add(grad);
        }

        public IEnumerable<Grad> Get()
        {
            return _context.Grad.ToList();
        }

        public Grad GetById(int id)
        {
            return _context.Grad.SingleOrDefault(w => w.Id == id);
        }

        public Grad GetByNaziv(string naziv)
        {
            return _context.Grad.SingleOrDefault(w => w.Naziv == naziv);
        }

        public bool Remove(int id)
        {
            var grad = _context.Grad.SingleOrDefault(w => w.Id == id);
            if(grad != null)
            {
                _context.Grad.Remove(grad);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Grad Update(int id, Grad grad)
        {
            var g = _context.Grad.SingleOrDefault(w => w.Id == id);
            if(g != null)
            {
                g = grad;
                _context.SaveChanges();
                return g;
            }
            return grad;
        }
    }
}
