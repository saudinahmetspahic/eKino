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
    public class ProdukcijskaKucaService : BaseCRUDService<Model.ProdukcijskaKuca, ProdukcijskaKucaSearchRequest, Database.ProdukcijskaKuca, ProdukcijskaKucaInsertRequest, ProdukcijskaKucaInsertRequest>
    {
        public ProdukcijskaKucaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<ProdukcijskaKuca> Get(ProdukcijskaKucaSearchRequest search)
        {
            var prKuce = _context.ProdukcijskaKuca.AsQueryable();

            if (!string.IsNullOrEmpty(search.Naziv))
            {
                prKuce = prKuce.Where(w => w.Naziv == search.Naziv);
            }

            return _mapper.Map<List<ProdukcijskaKuca>>(prKuce.ToList());
        }
    }
}
