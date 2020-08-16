using AutoMapper;
using eKino.API.EF;
using eKino.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class KomentarService : IKomentarService
    {
        private readonly MojContext _context;
        private readonly IMapper _mapper;

        public KomentarService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Komentar> Get(KomentarSerchRequest search)
        {
            var query = _context.Komentar.AsQueryable();

            if (search?.KomentatorId != null)
            {
                query = query.Where(x => x.KomentatorId == search.KomentatorId);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.Komentar>>(result);
        }
    }
}
