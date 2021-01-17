using AutoMapper;
using eKino.API.EF;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class UlogaService : BaseService<Model.Uloga, UlogaSearchRequest, Database.Uloga>
    {
        public UlogaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Uloga> Get([FromQuery]UlogaSearchRequest search)
        {
            var uloge = _context.Uloga.AsQueryable();

            if(search.Id > 0)
            {
                uloge = uloge.Where(w => w.Id == search.Id);
            }
            if(!string.IsNullOrEmpty(search?.NazivUloge))
            {
                uloge = uloge.Where(w => w.NazivUloge == search.NazivUloge);
            }

            return _mapper.Map<List<Uloga>>(uloge.ToList());
        }

     
    }
}
