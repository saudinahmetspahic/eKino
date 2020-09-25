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
    public class FilmProdukcijskeKuceService : BaseCRUDService<Model.FilmProdukcijskeKuce, FilmProdukcijskeKuceSearchRequest, Database.FilmProdukcijskeKuce, FilmProdukcijskeKuceInsertRequest, FilmProdukcijskeKuceInsertRequest>
    {
        public FilmProdukcijskeKuceService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<FilmProdukcijskeKuce> Get(FilmProdukcijskeKuceSearchRequest search)
        {
            var fk = _context.FilmProdukcijskeKuce.AsQueryable();

            if (search.FilmId != 0)
            {
                fk = fk.Where(w => w.FilmId == search.FilmId);
            }

            return _mapper.Map<List<FilmProdukcijskeKuce>>(fk.ToList());
        }
    }
}
