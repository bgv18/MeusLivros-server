using MeusLivros.Domain;
using MeusLivros.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeusLivros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivro _livroSevice;
        public LivroController(ILivro livro)
        {
            _livroSevice = livro;
        }

        [HttpPost("Create")]
        public IActionResult CreateLivro(Livro livro)
        {
            return _livroSevice.CreateLivro(livro) ? Ok() : BadRequest("Erro ao adicionar na fila!");
        }
    }
}
