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
    public class OcijenaController : BaseController<Model.Ocijena, OcijenaSearchRequest> //ControllerBase
    {
       // private readonly IService<Model.Ocijena, OcijenaSearchRequest> _service = null;
        public OcijenaController(IService<Model.Ocijena, OcijenaSearchRequest> service) : base(service)
        {
           //_service = service;
        }

        //[HttpGet]
        //public List<Model.Ocijena> Get([FromQuery] OcijenaSearchRequest request)
        //{
        //    return _service.Get(request);
        //}
    }
}
