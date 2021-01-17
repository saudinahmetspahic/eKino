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
    public class ZanrService : BaseService<Model.Zanr, ZanrSearchRequest, Database.Zanr>
    {
        public ZanrService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Zanr> Get([FromQuery]ZanrSearchRequest search)
        {
            var zanrovi = _context.Zanr.AsQueryable();

            if(search.Id > 0)
            {
                zanrovi = zanrovi.Where(w => w.Id == search.Id);
            }

            if (!string.IsNullOrEmpty(search.Naziv))
            {
                zanrovi = zanrovi.Where(w => w.NazivZanra == search.Naziv);
            }
            return _mapper.Map<List<Zanr>>(zanrovi.ToList());
        }
    }
}
