using AutoMapper;
using webapi_dotnet.Data.DTOs;
using webapi_dotnet.Models;

namespace webapi_dotnet.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<Endereco, UpdateEnderecoDto>();
            CreateMap<Endereco, ReadEnderecoDto>();
        }
    }
}