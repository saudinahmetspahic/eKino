using eKino.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model.Requests;

namespace eKino.API.Services
{
    public interface IFilmService
    {

        IEnumerable<Film> GetPreporuceneFilmove(int korisnikId);

    }
}
