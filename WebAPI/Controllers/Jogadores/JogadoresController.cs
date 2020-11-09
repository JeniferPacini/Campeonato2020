using Microsoft.AspNetCore.Mvc;
using Domain.Jogadores;

namespace WebAPI.Controllers.Jogadores
{
    [ApiController]
    [Route("[controller]")]
    public class JogadoresController : ControllerBase
    {
        private readonly ServicoJogadores _servicoJogadores;

        public JogadoresController()
        {
            _servicoJogadores = new ServicoJogadores();
        }
        
        [HttpPost]
        public IActionResult Create(CreateJogadorRequest request)
        {
            if(!request.Usuario.CBF)
            {
                return Forbid();
            }
            var jogador = new Jogador(request.Nome);
            return Ok(jogador.Id);
        }
        // [HttpGet]
        // public List<Usuario> Get()
        // {
        //     var usuario = new Usuario
        //     (
        //         "Afonso",
        //         false
        //     );
        //     return new List<Usuario>{usuario};
        // }
    }
}
