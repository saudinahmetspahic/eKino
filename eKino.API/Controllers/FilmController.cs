using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.Database;
using eKino.API.EF;
using eKino.API.Services;
using eKino.API.Util;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace eKino.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : BaseCRUDController<Model.Film, FilmSearchRequest, FilmInsertRequest, FilmInsertRequest>
    {
        private IMapper _mapper;
        private IFilmService _service;
        public FilmController(ICRUDService<Model.Film, FilmSearchRequest, FilmInsertRequest, FilmInsertRequest> service, IMapper mapper, IFilmService ser) : base(service)
        {
            _service = ser;
            _mapper = mapper;
        }


        [HttpGet("RecommendedFilmovi/{korisnikId}")]
        public IEnumerable<Model.Film> RecommendedFilmovi(string korisnikId)
        {
            return _service.GetPreporuceneFilmove(int.Parse(korisnikId));
        }

    }
}
