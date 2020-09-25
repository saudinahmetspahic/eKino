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
        //IEnumerable<Film> Get();
        IEnumerable<Film> GetByNaziv(string naziv);
        IEnumerable<Film> GetByZanr(string zanr);
        //Film GetById(int id);

        //void Add(Film film);

        //Film Update(int id, FilmInsertRequest film);

        //bool Remove(int id);
    }
}
