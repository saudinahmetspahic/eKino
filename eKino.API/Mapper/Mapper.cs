using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<API.Models.Film, Model.Film>().ReverseMap();
        }
    }
}
