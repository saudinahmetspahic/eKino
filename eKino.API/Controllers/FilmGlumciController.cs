using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmGlumciController : BaseCRUDController<Model.FilmGlumci, FilmGlumciSearchRequest, FilmGlumciInsertRequest, FilmGlumciInsertRequest>
    {
        public FilmGlumciController(Services.ICRUDService<Model.FilmGlumci, FilmGlumciSearchRequest, FilmGlumciInsertRequest, FilmGlumciInsertRequest> service) : base(service)
        {
        }
    }
}
