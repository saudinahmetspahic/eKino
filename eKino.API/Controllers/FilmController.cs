using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.Models;
using eKino.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eKino.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : Controller
    {
        private IFilmService _service = null;
        private IMapper _mapper = null;
        public FilmController(IFilmService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Model.Film> Get()
        {
            return _mapper.Map<IEnumerable<Model.Film>>(_service.Get());
        }

        [HttpPost]
        public void Post(Model.Film film)
        {
            _service.Add(film);
        }

        [HttpPut("{id}")]
        public Model.Film Update(int id, Model.Film film)
        {
            return _service.Update(id, film);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Remove(id);
        }
    }
}
