using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IUlogaService
    {
        public List<Model.Uloga> Get(UlogaSearchRequest search);
        public Model.Uloga GetByName(string name);
        public Model.Uloga GetById(int Id);
    }
}
