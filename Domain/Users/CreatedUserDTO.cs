using System;
using System.Collections.Generic;

namespace Domain.Users
{
    public class CreatedUserDto
    {
        public Guid Id { get; private set; }
        public IList<string> Errors { get; set; }
        public bool IsValid { get; set; }

        public CreatedUserDto(Guid id)
        {
            Id = id;
            IsValid = true;

        }
        public CreatedUserDto(IList<string> errors)
        {
            Errors = errors;
            IsValid = false;
        }
    }
}
