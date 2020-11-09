using Microsoft.AspNetCore.Mvc;
using Domain.Usuarios;
using WebAPI.Controllers.Users;
using System.Collections.Generic;
using System;

namespace WebAPI.Controllers.Usuarios
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ServicoUsuarios _servicoUsuarios;

        public UsersController()
        {
            _servicoUsuarios = new ServicoUsuarios();
        }

        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            if(request.CBF && request.Password != "admin123")
            {
                return Unauthorized();
            }
    
            var resposta = _servicoUsuarios.Create(request.Nome,request.CBF);

            if(!resposta.Valido)
            {
                return BadRequest(resposta.Erros);
            }

            return Ok(resposta.Id);
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
