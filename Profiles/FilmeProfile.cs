using AutoMapper;
using webapi_dotnet.DTOs;
using webapi_dotnet.Models;

namespace webapi_dotnet.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
        }
    }
}