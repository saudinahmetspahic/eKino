using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.API.EF;
using eKino.API.Services;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomentarController : BaseCRUDController<Model.Komentar, KomentarSearchRequest, KomentarInsertRequest, KomentarInsertRequest>
    {
        public KomentarController(ICRUDService<Komentar, KomentarSearchRequest, KomentarInsertRequest, KomentarInsertRequest> service) : base(service)
        {
        }
    }
}
