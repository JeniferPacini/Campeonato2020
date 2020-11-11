using Microsoft.AspNetCore.Mvc;
using Domain.Jogadores;
using Microsoft.Extensions.Primitives;
using Domain.Usuarios;
using System;

namespace WebAPI.Controllers.Jogadores
{
    [ApiController]
    [Route("[controller]")]
    public class JogadoresController : ControllerBase
    {
        private readonly ServicoJogadores _servicoJogadores;
        private readonly ServicoUsuarios _servicoUsuarios;

        public JogadoresController()
        {
            _servicoJogadores = new ServicoJogadores();
            _servicoUsuarios = new ServicoUsuarios();
        }
        
        [HttpPost]
        public IActionResult Create(CreateJogadorRequest request)
        {
            StringValues usuarioId;
            if(!Request.Headers.TryGetValue("UsuarioId", out usuarioId))
            {
                return Unauthorized();
            }

            var usuario = _servicoUsuarios.GetById(Guid.Parse(usuarioId));
            
            if(usuario == null)
            {
                return Unauthorized();
            }
            
            if(!usuario.CBF)
            {
                return Unauthorized();
                //return Forbid("Test");
            }
            var resposta = _servicoJogadores.Create(request.Nome);

            if(!resposta.Valido)
            {
                return BadRequest(resposta.Erros);
            }
            return Ok(resposta.Id);
        }
    }
}
