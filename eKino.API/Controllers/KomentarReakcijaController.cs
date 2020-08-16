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
    public class KomentarReakcijaController : ControllerBase
    {
        private readonly IKomentarReakcijaService _service;

        public KomentarReakcijaController(IKomentarReakcijaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<KomentarReakcija> Get([FromQuery]KomentarSerchRequest search)
        {
            return _service.Get(search);
        }
    }
}
