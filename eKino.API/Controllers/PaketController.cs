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
    public class PaketController : BaseController<Model.Paket, KorisnikPaketSearchRequest> //: ControllerBase
    {
      // public readonly IPaketService _service;

        public PaketController(IService<Model.Paket, KorisnikPaketSearchRequest> service) : base(service)
        {
            //_service = service;
        }

        //[HttpGet]
        //public List<Model.Paket> Get([FromQuery]KorisnikPaketSearchRequest search)
        //{
        //    return _service.Get(search);
        //}
    }
}
