using AutoMapper;
using eKino.API.EF;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class TipService : BaseService<Model.Tip, TipSearchRequest, Database.Tip>
    {
        public TipService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
