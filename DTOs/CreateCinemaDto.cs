using System.ComponentModel.DataAnnotations;

namespace webapi_dotnet.DTOs
{
    public class CreateCinemaDto
    {

        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string Nome { get; set; }
    }
}