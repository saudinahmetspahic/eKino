using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.Database;
using eKino.API.Services;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Authorization;
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
        public List<Model.Korisnik> Get([FromQuery]KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }

        // GET api/<KorisnikController>/5
        [HttpGet("{id}")]
        public Model.Korisnik Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("PoEmailu/{email}")]
        public Model.Korisnik GetByEmail(string email)
        {
            return _service.GetByEmail(email);
        }

        [HttpGet("PoImenu/{ime}")]
        public Model.Korisnik GetByIme(string ime)
        {
            return _service.GetByIme(ime);
        }

        [HttpGet("PoPrezimenu/{prezime}")]
        public Model.Korisnik GetByPrezime(string prezime)
        {
            return _service.GetByIme(prezime);
        }

        // POST api/<KorisnikController>
        [HttpPost]
        public void Post(KorisnikInsertRequest korisnik)
        {
            _service.Add(korisnik);
        }

        // PUT api/<KorisnikController>/5
        [HttpPut("{id}")]
        public Model.Korisnik Put(int id, KorisnikInsertRequest korisnik)
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
