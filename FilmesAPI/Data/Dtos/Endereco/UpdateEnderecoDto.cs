using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        [Required(ErrorMessage = "O campo de Descricao é obrigatório.")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo de Numero é obrigatório.")]
        public int Numero { get; set; }
    }
}
