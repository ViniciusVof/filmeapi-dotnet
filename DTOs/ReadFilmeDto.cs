using System.ComponentModel.DataAnnotations;

namespace webapi_dotnet.DTOs
{
    public class ReadFilmeDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
    }
}