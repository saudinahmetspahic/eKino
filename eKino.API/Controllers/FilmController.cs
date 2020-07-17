using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.Database;
using eKino.API.Services;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eKino.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
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

        [HttpGet("{id}")]
        public Model.Film GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("PoNazivu/{naziv}")]
        public IEnumerable<Model.Film> GetByNaziv(string naziv)
        {
            return _service.GetByNaziv(naziv);
        }


        [HttpGet("PoZanru/{zanr}")]
        public IEnumerable<Model.Film> GetByZanr(string zanr)
        {
            return _service.GetByZanr(zanr);
        }

        [HttpPost]
        public void Add(Model.Film film)
        {
            _service.Add(film);
        }

        [HttpPut("{id}")]
        public Model.Film Update(int id, FilmInsertRequest film)
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
