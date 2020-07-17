using AutoMapper;
using eKino.API.Database;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model.Requests;

namespace eKino.API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<API.Database.Film, Model.Film>().ReverseMap();
            CreateMap<API.Database.Film, FilmInsertRequest>().ReverseMap();

            CreateMap<API.Database.Korisnik, Model.Korisnik>().ReverseMap();
        }
    }
}
