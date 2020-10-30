using Domain.Usuarios;

namespace WebAPI.Controllers.Users
{
    public class CreateUserRequest
    {
        public string Nome { get; set; }
        public bool CBF { get; set; }
    }
}