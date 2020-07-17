using eKino.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IKorisnikService
    {
        public IEnumerable<Korisnik> Get();
        public Korisnik GetById(int id);
        public Model.Korisnik GetByIme(string ime);
        public void Add(Korisnik korisnik);
        public Korisnik Update(int id, Korisnik korisnik);
        public bool Remove(int id);
    }
}
