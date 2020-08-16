using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IRezervacijaService
    {
        public List<Model.Rezervacija> Get(RezervacijaSearchRequest search);
    }
}
