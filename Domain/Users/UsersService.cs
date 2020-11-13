using System;
using System.Linq;
using Domain.Users;

namespace Domain.Users
{
    public class UsersService
    {
        public CreatedUserDto Create(string name, bool cbf)
        {
            var user = new User(name, cbf);
            var validateUser = user.Validate();

            if(validateUser.isValid)
            {
                UsersRepository.Add(user);
                return new CreatedUserDto(user.Id);
            }

            return new CreatedUserDto(validateUser.errors);
        }

        public User GetById(Guid id)
        {
            return UsersRepository.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
