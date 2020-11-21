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
    public class UlogaController : ControllerBase
    {
     
        private readonly IUlogaService _ulogaApiService;

        public UlogaController(IUlogaService ulogaApiService)
        {
            _ulogaApiService = ulogaApiService;
        }
        [HttpGet]
        public List<Model.Uloga> Get([FromQuery]UlogaSearchRequest search)
        {
            return _ulogaApiService.Get(search);
        }

        [HttpGet("PoNazivu/{name}")]
        public Model.Uloga GetByName(string name)
        {
            return _ulogaApiService.GetByName(name);
        }

        [HttpGet("{Id}")]
        public Model.Uloga GetById(int Id)
        {
            return _ulogaApiService.GetById(Id);
        }
    }
}
