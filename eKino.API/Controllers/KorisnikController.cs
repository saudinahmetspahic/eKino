using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _service = null;
        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }

        // GET: api/<KorisnikController>
        [HttpGet]
        public IEnumerable<Model.Korisnik> Get()
        {
            return _service.Get();
        }

        // GET api/<KorisnikController>/5
        [HttpGet("{id}")]
        public Model.Korisnik Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("PoImenu/{naziv}")]
        public Model.Korisnik GetByIme(string naziv)
        {
            return _service.GetByIme(naziv);
        }

        // POST api/<KorisnikController>
        [HttpPost]
        public void Post(Model.Korisnik korisnik)
        {
            _service.Add(korisnik);
        }

        // PUT api/<KorisnikController>/5
        [HttpPut("{id}")]
        public Model.Korisnik Put(int id, Model.Korisnik korisnik)
        {
            return _service.Update(id, korisnik);
        }

        // DELETE api/<KorisnikController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Remove(id);
        }
    }
}
