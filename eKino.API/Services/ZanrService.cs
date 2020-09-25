using AutoMapper;
using eKino.API.EF;
using eKino.Model.Requests;
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
    }
}
