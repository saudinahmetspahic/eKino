using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using eKino.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class PaketService : BaseService<Model.Paket, KorisnikPaketSearchRequest, Database.Paket>, IPaketService
    {

        public PaketService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Paket> Get(KorisnikPaketSearchRequest search)
        {
            var query = _context.KorisnikPaket.AsQueryable();

            if (search?.KorisnikId != null)
            {
                query = query.Include(i => i.Paket).Where(x => x.KorisnikId == search.KorisnikId);
            }

            if (search?.PaketId != null)
            {
                query = query.Include(i => i.Korisnik).Where(x => x.PaketId == search.PaketId);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.Paket>>(result);
        }

    }
}
