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
            CreateMap<API.Database.Korisnik, Model.Requests.KorisnikInsertRequest>().ReverseMap();
            CreateMap<API.Database.Korisnik, Model.Requests.OsobaInsertRequest>().ReverseMap();

            CreateMap<API.Database.Grad, Model.Grad>().ReverseMap();
            CreateMap<API.Database.Uloga, Model.Uloga>().ReverseMap();
            CreateMap<API.Database.Paket, Model.Paket>().ReverseMap();
            CreateMap<API.Database.Ocijena, Model.Ocijena>().ReverseMap();
            CreateMap<API.Database.Rezervacija, Model.Rezervacija>().ReverseMap();
            CreateMap<API.Database.Komentar, Model.Komentar>().ReverseMap();
            CreateMap<API.Database.KomentarReakcija, Model.KomentarReakcija>().ReverseMap();
        }
    }
}
