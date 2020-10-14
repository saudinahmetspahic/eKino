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
    public class KorisnikController : BaseCRUDController<Model.Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikInsertRequest>
    {
        public KorisnikController(ICRUDService<Model.Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikInsertRequest> _CRUDService) : base(_CRUDService)
        {
        }

        //[HttpGet("PoEmailu/{email}")]
        //public Model.Korisnik GetByEmail(string email)
        //{
        //    return _service.GetByEmail(email);
        //}

        //[HttpGet("PoImenu/{ime}")]
        //public Model.Korisnik GetByIme(string ime)
        //{
        //    return _service.GetByIme(ime);
        //}

        //[HttpGet("PoPrezimenu/{prezime}")]
        //public Model.Korisnik GetByPrezime(string prezime)
        //{
        //    return _service.GetByIme(prezime);
        //}

     
    }
}
