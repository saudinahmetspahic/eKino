using eKino.API.Services;
using eKino.Model;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Controllers
{
    public class PrijavaController : BaseCRUDController<Model.Prijava, PrijavaSearchRequest, PrijavaInsertRequest, PrijavaInsertRequest>
    {
        public PrijavaController(ICRUDService<Prijava, PrijavaSearchRequest, PrijavaInsertRequest, PrijavaInsertRequest> service) : base(service)
        {
        }

    }
}
