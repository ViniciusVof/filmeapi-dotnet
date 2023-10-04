using System.ComponentModel.DataAnnotations;

namespace webapi_dotnet.Data.DTOs
{
    public class UpdateCinemaDto
    {

        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string Nome { get; set; }

    }
}