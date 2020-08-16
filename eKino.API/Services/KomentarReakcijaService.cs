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
    public class KomentarReakcijaService : IKomentarReakcijaService
    {
        private readonly MojContext _context = null;
        private readonly IMapper _mapper = null;
        public KomentarReakcijaService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<KomentarReakcija> Get(KomentarSerchRequest search) // KomentarSerchRequest
        {
            var query = _context.KomentarReakcija.AsQueryable();

            if (search?.KomentatorId != null)
            {
                query = query.Where(x => x.Komentar.KomentatorId == search.KomentatorId);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.KomentarReakcija>>(result);

        }
    }
}
