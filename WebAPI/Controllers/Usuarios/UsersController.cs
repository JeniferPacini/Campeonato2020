using Microsoft.AspNetCore.Mvc;
using Domain.Usuarios;
using WebAPI.Controllers.Users;
using System.Collections.Generic;

namespace WebAPI.Controllers.Usuarios
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        // [HttpPost]
        // public string Post(CreateUserRequest request)
        // {
        //     var usuario = new Usuario(request.Nome, request.CBF);
        //     return usuario.Nome;
        // }
        [HttpGet]
        public List<Usuario> Get()
        {
            var usuario = new Usuario
            (
                "Afonso",
                false
            );
            return new List<Usuario>{usuario};
        }
    }
}
