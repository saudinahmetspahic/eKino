using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.API.Services;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipController : BaseController<Model.Tip, TipSearchRequest>
    {
        public TipController(IService<Tip, TipSearchRequest> service) : base(service)
        {
        }
    }
}
