using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using eKino.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public class PaketService : BaseCRUDService<Model.Paket, PaketSearchRequest, Database.Paket, PaketInsertRequest, PaketInsertRequest>
    {

        public PaketService(MojContext context, IMapper mapper) : base(context, mapper)
        {
        }


    }
}
