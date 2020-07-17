using eKino.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IKorisnikService
    {
        public IEnumerable<Model.Korisnik> Get();
        public Model.Korisnik GetById(int id);
        public Model.Korisnik GetByIme(string ime);
        public void Add(Model.Korisnik korisnik);
        public Model.Korisnik Update(int id, Model.Korisnik korisnik);
        public bool Remove(int id);
    }
}
