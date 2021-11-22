using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {

        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {

            filme.Id = id++;
            filmes.Add(filme);
            //return new CreatedAtActionResult(nameof(RecuperaFilmesPorId), nameof(FilmeController), new { Id = filme.Id }, filme);
            
        }

        [HttpGet]
        public IActionResult RecuperarFilmes()
        {

            return new OkObjectResult(filmes);

        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Filme))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RecuperaFilmesPorId(int Id)
        {
           
            Filme filme = filmes.FirstOrDefault(filme => filme.Id == Id);
            
            if(filme != null)
            {
                return new OkObjectResult(filme);
            }
            return new NotFoundResult();



            /* foreach(Filme filme in filmes)
            {
                if(filme.Id == Id)
                {
                    return filme;
                }
            }
            return null; */
        }

    }
}
