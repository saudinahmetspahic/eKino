using eKino.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IGradService
    {
        public List<Model.Grad> Get();
        public Model.Grad GetByNaziv(string naziv);
        public Model.Grad GetById(int id);
        public void Add(Model.Grad grad);
        public Model.Grad Update(int id, Model.Grad grad);
        public bool Remove(int id);
    }
}
