using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class GradService : BaseService<Model.Grad, GradSearchRequest, Database.Grad> 
    {
        public GradService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Grad> Get([FromQuery]GradSearchRequest search)
        {
            var gradovi = _context.Grad.AsQueryable();

            if(search.Id > 0)
            {
                gradovi = gradovi.Where(w => w.Id == search.Id);
            }
            if (!string.IsNullOrEmpty(search.Naziv))
            {
                gradovi = gradovi.Where(w => w.Naziv == search.Naziv);
            }

            return _mapper.Map<List<Model.Grad>>(gradovi.ToList());
        }

     
    }
}
