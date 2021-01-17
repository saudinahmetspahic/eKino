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
    public class OsobaService : BaseCRUDService<Model.Osoba, OsobaSearchRequest, Database.Osoba, OsobaInsertRequest, OsobaInsertRequest>
    {
        public OsobaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Osoba> Get(OsobaSearchRequest search)
        {
            var osobe = _context.Osoba.AsQueryable();

            if(search.OsobaId > 0)
            {
                osobe = osobe.Where(w => w.Id == search.OsobaId);
            }
            if (!string.IsNullOrEmpty(search.Uloga))
            {
                osobe = osobe.Where(w => w.Uloga.NazivUloge == search.Uloga);
            }
            if (!string.IsNullOrEmpty(search.Ime))
            {
                osobe = osobe.Where(w => w.Ime == search.Ime);
            }
            if (!string.IsNullOrEmpty(search.Prezime))
            {
                osobe = osobe.Where(w => w.Prezime == search.Prezime);
            }

            return _mapper.Map<List<Osoba>>(osobe.ToList());
        }
    }
}
