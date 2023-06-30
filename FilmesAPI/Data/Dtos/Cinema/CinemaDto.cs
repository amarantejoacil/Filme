using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Cinema
{
    public class CinemaDto
    {

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }
    }
}
