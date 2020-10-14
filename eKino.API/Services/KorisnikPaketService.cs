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
    public class KorisnikPaketService : BaseCRUDService<Model.KorisnikPaket, KorisnikPaketSearchRequest, Database.KorisnikPaket, KorisnikPaketInsertRequest, KorisnikPaketInsertRequest>
    {
        public KorisnikPaketService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<KorisnikPaket> Get(KorisnikPaketSearchRequest search)
        {
            var query = _context.KorisnikPaket.AsQueryable();

            if(search.KorisnikId > 0)
            {
                query = query.Where(w => w.KorisnikId == search.KorisnikId);
            }
            if (search.PaketId > 0)
            {
                query = query.Where(w => w.PaketId == search.PaketId);
            }

            return _mapper.Map<List<KorisnikPaket>>(query.ToList());
        }
    }
}
