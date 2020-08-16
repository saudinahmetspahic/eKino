using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IKomentarService
    {
        public List<Model.Komentar> Get(KomentarSerchRequest search);
    }
}
