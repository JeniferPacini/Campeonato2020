namespace WebAPI.Controllers.Users
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public bool CBF { get; set; }
        public string Password { get; set; }
    }
}