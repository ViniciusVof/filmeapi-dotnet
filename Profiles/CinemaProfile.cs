using AutoMapper;
using webapi_dotnet.Data.DTOs;
using webapi_dotnet.Models;

namespace webapi_dotnet.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<UpdateCinemaDto, Cinema>();
            CreateMap<Cinema, UpdateCinemaDto>();
            CreateMap<Cinema, ReadCinemaDto>();
        }
    }
}