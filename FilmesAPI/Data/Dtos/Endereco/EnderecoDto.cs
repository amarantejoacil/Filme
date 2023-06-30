using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class EnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição do endereço é obrigatória!")]
        public string Descricao { get; set; }
        [Required]
        public int Numero { get; set; }
    }
}
