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
    public class OcijenaService : BaseCRUDService<Model.Ocijena, OcijenaSearchRequest, Database.Ocijena, OcijenaInsertRequest, OcijenaInsertRequest>, IOcijenaService
    {
        public OcijenaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Ocijena> Get(OcijenaSearchRequest search)
        {
            var query = _context.Ocijena.AsQueryable();

            if(search.KorisnikId != 0)
            {
                query = query.Where(w => w.KomentatorId == search.KorisnikId);
            }
            if(search.FilmId != 0)
            {
                query = query.Where(w => w.FilmId == search.FilmId);
            }
            var result = query.ToList();
            return _mapper.Map<List<Model.Ocijena>>(result);
        }

    }
}
