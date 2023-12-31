using System.ComponentModel.DataAnnotations;

namespace webapi_dotnet.Data.DTOs
{
    public class CreateCinemaDto
    {

        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
}