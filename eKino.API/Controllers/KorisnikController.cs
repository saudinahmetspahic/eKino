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
        ICRUDService<Model.Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikInsertRequest> _service;
        public KorisnikController(ICRUDService<Model.Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikInsertRequest> _CRUDService) : base(_CRUDService)
        {
            _service = _CRUDService;
        }

        [AllowAnonymous]
        [HttpPost]
        public override void Insert(KorisnikInsertRequest request)
        {
            _service.Insert(request);
        }

        [AllowAnonymous]
        [HttpGet]
        public override List<Model.Korisnik> Get([FromQuery] KorisnikSearchRequest search)
        {
            return base.Get(search);
        }

    }
}
