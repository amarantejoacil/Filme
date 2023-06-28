using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {


        [Required(ErrorMessage = "Título do filme é obrigatório")]
        [StringLength(30)]
        public string Titulo { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve conter em 70 e 600 minutos!")]
        public int Duracao { get; set; }
    }
}
