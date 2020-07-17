using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.API.Database;
using eKino.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradController : ControllerBase
    {
        private readonly IGradService _service = null;
        public GradController(IGradService service)
        {
            _service = service;
        }
        // GET: api/<GradController>
        [HttpGet]
        public IEnumerable<Grad> Get()
        {
            return _service.Get();
        }

        // GET api/<GradController>/5
        [HttpGet("{id}")]
        public Grad GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("PoNazivu/{naziv}")]
        public Grad GetByNaziv(string naziv)
        {
            return _service.GetByNaziv(naziv);
        }

        // POST api/<GradController>
        [HttpPost]
        public void Post(Grad grad)
        {
            _service.Add(grad);
        }

        // PUT api/<GradController>/5
        [HttpPut("{id}")]
        public void Put(int id, Grad grad)
        {
            _service.Update(id, grad); 
        }

        // DELETE api/<GradController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Remove(id);
        }
    }
}
