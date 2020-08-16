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
    public class PaketService : IPaketService
    {
        private readonly MojContext _context;
        private readonly IMapper _mapper;

        public PaketService(MojContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Paket> Get(KorisnikPaketSearchRequest search)
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
