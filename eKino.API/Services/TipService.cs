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
    public class TipService : BaseService<Model.Tip, TipSearchRequest, Database.Tip>
    {
        public TipService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Tip> Get(TipSearchRequest search)
        {
            var tipovi = _context.Tip.AsQueryable();

            if (search.Id > 0)
            {
                tipovi = tipovi.Where(w => w.Id == search.Id);
            }

            if (!string.IsNullOrEmpty(search.Naziv))
            {
                tipovi = tipovi.Where(w => w.NazivTipa == search.Naziv);
            }
            return _mapper.Map<List<Tip>>(tipovi.ToList());
        }
    }
}
