using AutoMapper;
using eKino.API.EF;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class DvoranaService : BaseService<Model.Dvorana, DvoranaSearchRequest, Database.Dvorana>
    {
        public DvoranaService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
