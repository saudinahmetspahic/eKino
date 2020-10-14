using AutoMapper;
using eKino.API.EF;
using eKino.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class KomentarService : BaseCRUDService<Model.Komentar, KomentarSearchRequest, Database.Komentar, KomentarInsertRequest, KomentarInsertRequest>
    {
        public KomentarService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Komentar> Get(KomentarSearchRequest search)
        {
            var query = _context.Komentar.AsQueryable();

            if (search?.KomentatorId > 0)
            {
                query = query.Where(x => x.KomentatorId == search.KomentatorId);
            }
            if (search?.FilmId > 0)
            {
                query = query.Where(x => x.FilmId == search.FilmId);
            }
            if (!string.IsNullOrEmpty(search?.SadrzajKomentara))
            {
                query = query.Where(x => x.SadrzajKomentara.Contains(search.SadrzajKomentara) == true);
            }

            var result = query.ToList();
            return _mapper.Map<List<Model.Komentar>>(result);
        }
    }
}
