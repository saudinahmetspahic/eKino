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
    public class FilmScenaristiController : BaseCRUDController<Model.FilmScenaristi, FilmScenaristiSearchRequest, FilmScenaristiInsertRequest, FilmScenaristiInsertRequest>
    {
        public FilmScenaristiController(Services.ICRUDService<Model.FilmScenaristi, FilmScenaristiSearchRequest, FilmScenaristiInsertRequest, FilmScenaristiInsertRequest> service) : base(service)
        {
        }
    }
}
