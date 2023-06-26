using AutoMapper;
using PeliculasAPI.DTOs;
using PeliculasAPI.Entidades;


namespace PeliculasAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        protected AutoMapperProfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();
        }
    }
}
