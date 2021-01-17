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
    public class DvoranaService : BaseService<Model.Dvorana, DvoranaSearchRequest, Database.Dvorana>
    {
        public DvoranaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Dvorana> Get(DvoranaSearchRequest search)
        {
            var query = _context.Dvorana.AsQueryable();

            if(search.Id > 0)
            {
                query = query.Where(w => w.Id == search.Id);
            }
            if (!string.IsNullOrEmpty(search.Naziv))
            {
                query = query.Where(w => w.Naziv.Contains(search.Naziv));
            }

            return _mapper.Map<List<Model.Dvorana>>(query.ToList());
        }
    }
}
