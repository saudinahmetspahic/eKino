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
    public class PrijavaService : BaseCRUDService<Model.Prijava, PrijavaSearchRequest, Database.Prijava, PrijavaInsertRequest, PrijavaInsertRequest>
    {
        public PrijavaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Prijava> Get(PrijavaSearchRequest search)
        {
            var prijave = _context.Prijava.AsQueryable();

            if (search.FilmId > 0)
            {
                prijave = prijave.Where(w => w.FilmId == search.FilmId);
            }

            return _mapper.Map<List<Prijava>>(prijave.ToList());

        }

        public override Prijava Update(int id, PrijavaInsertRequest request)
        {
            var prijava = _context.Prijava.Find(id);
            prijava.Rijeseno = request.Rijeseno;
            _context.Prijava.Update(prijava);
            _context.SaveChanges();
            return _mapper.Map<Model.Prijava>(prijava);
        }
    }
}
