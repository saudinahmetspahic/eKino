using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IKomentarReakcijaService
    {
        public List<Model.KomentarReakcija> Get(KomentarSerchRequest search);
    }
}
