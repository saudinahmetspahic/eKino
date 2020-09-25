using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.API.Database;
using eKino.API.Services;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaketController : BaseCRUDController<Model.Paket, PaketSearchRequest, PaketInsertRequest, PaketInsertRequest>
    {
        public PaketController(ICRUDService<Model.Paket, PaketSearchRequest, PaketInsertRequest, PaketInsertRequest> service) : base(service)
        {
        }
    }
}
