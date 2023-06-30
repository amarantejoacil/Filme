using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "A descrição do endereço é obrigatória!")]
        public string Descricao { get; set; }
        [Required]
        public int Numero { get; set; }

        public virtual Cinema Cinema { get; set; }
    }
}
