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
    public class KomentarReakcijaService : BaseCRUDService<Model.KomentarReakcija, KomentarReakcijaSearchRequest, Database.KomentarReakcija, KomentarReakcijaInsertRequest, KomentarReakcijaInsertRequest>
    {
        public KomentarReakcijaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<KomentarReakcija> Get(KomentarReakcijaSearchRequest search) 
        {
            var query = _context.KomentarReakcija.AsQueryable();

            if (search?.KomentarId > 0)
            {
                query = query.Where(x => x.KomentarId == search.KomentarId);
            }
            if (search?.KorisnikId > 0)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.KomentarReakcija>>(result);

        }
    }
}
