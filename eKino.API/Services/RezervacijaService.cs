using AutoMapper;
using eKino.API.EF;
using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class RezervacijaService : BaseCRUDService<Model.Rezervacija, RezervacijaSearchRequest, Database.Rezervacija, RezervacijaInsertRequest, RezervacijaInsertRequest>
    {
        public RezervacijaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Rezervacija> Get(RezervacijaSearchRequest search)
        {
            var query = _context.Rezervacija.AsQueryable();

            if (search?.KorisnikId > 0)
            {
                query = query.Where(x => x.KupacId == search.KorisnikId);
            }
            if(search?.ProjekcijaId > 0)
            {
                query = query.Where(w => w.ProjekcijaId == search.ProjekcijaId);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.Rezervacija>>(result);
        }
    }
}
