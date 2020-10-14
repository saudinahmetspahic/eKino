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
    public class KorisnikPaketController : BaseCRUDController<Model.KorisnikPaket, KorisnikPaketSearchRequest, KorisnikPaketInsertRequest, KorisnikPaketInsertRequest>
    {
        public KorisnikPaketController(Services.ICRUDService<Model.KorisnikPaket, KorisnikPaketSearchRequest, KorisnikPaketInsertRequest, KorisnikPaketInsertRequest> service) : base(service)
        {
        }
    }
}
