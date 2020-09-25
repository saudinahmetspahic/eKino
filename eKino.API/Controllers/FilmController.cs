using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.Database;
using eKino.API.Services;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eKino.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : BaseCRUDController<Model.Film, FilmSearchRequest, FilmInsertRequest, FilmInsertRequest>
    {
        private IFilmService _service;
        public FilmController(ICRUDService<Model.Film, FilmSearchRequest, FilmInsertRequest, FilmInsertRequest> service, IMapper mapper, IFilmService ser) : base(service)
        {
            _service = ser;
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

    }
}
