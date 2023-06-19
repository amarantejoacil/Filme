using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {


        private static List<Filme> filmes = new List<Filme>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {


            filme.Id = id++;
            filmes.Add(filme);
            //ao criar o filme, retorna o filme que foi adicionado
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
            //Console.WriteLine(filme.Titulo);
            //Console.WriteLine(filme.Duracao);
        }


        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return filmes.Skip(skip).Take(take);
            //skip =  pular... a partir de x  
            //take = pegar... pegue x registro
            //tem como objetivo otimizar a consulta
        }

        //interrogação significa que ele pode retorna nulo
        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            //para cada elementos de filmes, busco id do filme, igual id parametro, se for retorna o id, caso contrario return nul
            var filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            return Ok(filme);

        }
    }
}


