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
    public class FilmScenaristiService : BaseCRUDService<Model.FilmScenaristi, FilmScenaristiSearchRequest, Database.FilmScenaristi, FilmScenaristiInsertRequest, FilmScenaristiInsertRequest>
    {
        public FilmScenaristiService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<FilmScenaristi> Get(FilmScenaristiSearchRequest search)
        {
            var fs = _context.FilmScenaristi.AsQueryable();

            if(search.FilmId != 0)
            {
                fs = fs.Where(w => w.FilmId == search.FilmId);
            }
            if(search.ScenaristId != 0)
            {
                fs = fs.Where(w => w.ScenaristId == search.ScenaristId);
            }

            return _mapper.Map<List<FilmScenaristi>>(fs.ToList());
        }
    }
}
