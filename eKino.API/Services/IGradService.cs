using eKino.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    interface IGradService
    {
        IEnumerable<Grad> Get();
        Grad GetByNaziv(string naziv);
        Grad GetById(int id);

        void Add(Grad grad);

        Grad Update(int id, Grad grad);

        bool Remove(int id);
    }
}
