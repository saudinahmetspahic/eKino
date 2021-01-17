using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.API.Services;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogaController : BaseController<Model.Uloga, UlogaSearchRequest> // : ControllerBase
    {
        public UlogaController(IService<Uloga, UlogaSearchRequest> service) : base(service)
        {
        }

        [AllowAnonymous]
        [HttpGet]
        public override List<Uloga> Get([FromQuery] UlogaSearchRequest search)
        {
            return base.Get(search);
        }

    }
}
