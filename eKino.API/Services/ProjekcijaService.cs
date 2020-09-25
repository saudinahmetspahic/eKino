using AutoMapper;
using eKino.API.EF;
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
    }
}
