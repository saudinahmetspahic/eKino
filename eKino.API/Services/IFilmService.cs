using eKino.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Services
{
    public interface IFilmService
    {
        IEnumerable<Film> Get();
        Film GetById(int id);

        void Add(Film film);

        Film Update(int id, Film film);

        bool Remove(int id);
    }
}
