using eKino.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IGradService
    {
        public IEnumerable<Grad> Get();
        public Grad GetByNaziv(string naziv);
        public Grad GetById(int id);
        public void Add(Grad grad);
        public Grad Update(int id, Grad grad);
        public bool Remove(int id);
    }
}
