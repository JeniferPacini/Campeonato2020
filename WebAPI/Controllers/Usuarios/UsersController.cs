using Microsoft.AspNetCore.Mvc;
using Domain.Users;
using WebAPI.Controllers.Users;

namespace WebAPI.Controllers.Usuarios
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;

        public UsersController()
        {
            _usersService = new UsersService();
        }

        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            if(request.CBF && request.Password != "admin123")
            {
                return Unauthorized();
            }
    
            var response = _usersService.Create(request.Name,request.CBF);

            if(!response.IsValid)
            {
                return BadRequest(response.Errors);
            }

            return Ok(response.Id);
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
