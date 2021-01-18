using System;
using System.Collections.Generic;
using System.Linq;
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
    public class GradController : BaseController<Model.Grad, GradSearchRequest> //: ControllerBase
    {
        public GradController(IService<Model.Grad, GradSearchRequest> service) : base(service)
        {
        }

    }
}
