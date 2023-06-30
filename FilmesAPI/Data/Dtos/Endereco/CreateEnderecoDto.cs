using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {
        public string Descricao { get; set; }
        public int Numero { get; set; }
    }
}
