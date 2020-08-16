using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.API.EF;
using eKino.API.Services;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomentarController : ControllerBase
    {
        private readonly IKomentarService _service;

        public KomentarController(IKomentarService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public List<Model.Komentar> Get([FromQuery]KomentarSerchRequest search)
        {
            return _service.Get(search);
        }
    }
}
