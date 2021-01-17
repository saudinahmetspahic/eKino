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
    public class ProjekcijaService : BaseCRUDService<Model.Projekcija, ProjekcijaSearchRequest, Database.Projekcija, ProjekcijaInsertRequest, ProjekcijaInsertRequest>
    {
        public ProjekcijaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Projekcija> Get(ProjekcijaSearchRequest search)
        {
            var query = _context.Projekcija.AsQueryable();
            
            if(search.Id > 0)
            {
                query = query.Where(w => w.Id == search.Id);
            }
            if (search.DvoranaId > 0)
            {
                query = query.Where(w => w.DvoranaId == search.DvoranaId);
            }
            if (search.FilmId > 0)
            {
                query = query.Where(w => w.FilmId == search.FilmId);
            }    

            return _mapper.Map<List<Model.Projekcija>>(query.ToList());
        }
    }
}
