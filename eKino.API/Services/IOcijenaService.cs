using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IOcijenaService
    {
        public List<Model.Ocijena> Get(OcijenaSearchRequest search);
    }
}
