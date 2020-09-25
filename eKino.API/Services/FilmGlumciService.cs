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
    public class FilmGlumciService : BaseCRUDService<Model.FilmGlumci, FilmGlumciSearchRequest, Database.FilmGlumci, FilmGlumciInsertRequest, FilmGlumciInsertRequest>
    {
        public FilmGlumciService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<FilmGlumci> Get(FilmGlumciSearchRequest search)
        {
            var fg = _context.FilmGlumci.AsQueryable();

            if(search.FilmId != 0)
            {
                fg = fg.Where(w => w.FilmId == search.FilmId);
            }
            if (search.GlumacId != 0)
            {
                fg = fg.Where(w => w.GlumacId == search.GlumacId);
            }
            return _mapper.Map<List<FilmGlumci>>(fg.ToList());
        }
    }
}
