using System.ComponentModel.DataAnnotations;

namespace webapi_dotnet.Data.DTOs
{
    public class UpdateEnderecoDto
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }

    }
}