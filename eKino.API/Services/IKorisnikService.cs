using eKino.API.Database;
using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IKorisnikService
    {
        public List<Model.Korisnik> Get(KorisnikSearchRequest request);
        public Model.Korisnik GetById(int id);
        public Model.Korisnik GetByEmail(string email);
        public Model.Korisnik GetByIme(string ime);
        public Model.Korisnik GetByPrezime(string prezime);
        public void Add(KorisnikInsertRequest korisnik);
        public Model.Korisnik Update(int id, KorisnikInsertRequest korisnik);
        public bool Remove(int id);
        Model.Korisnik Authenticate(KorisnikLoginRequest request);
    }
}
