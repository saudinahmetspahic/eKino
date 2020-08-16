using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.Database;
using eKino.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eKino.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class GradController : ControllerBase
    {
        private readonly IGradService _service = null;
        private readonly IMapper _mapper = null;
        public GradController(IGradService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/<GradController>
        [HttpGet]
        public List<Model.Grad> Get()
        {
            var g = _service.Get();
            return g;
        }

        // GET api/<GradController>/5
        [HttpGet("{id}")]
        public Model.Grad GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("PoNazivu/{naziv}")]
        public Model.Grad GetByNaziv(string naziv)
        {
            return _service.GetByNaziv(naziv);
        }

        // POST api/<GradController>
        [HttpPost]
        public void Post(Model.Grad grad)
        {
            _service.Add(grad);
        }

        // PUT api/<GradController>/5
        [HttpPut("{id}")]
        public void Put(int id, Model.Grad grad)
        {
            _service.Update(id, grad); 
        }

        // DELETE api/<GradController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Remove(id);
        }
    }
}
