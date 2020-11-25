using System;
using System.Collections.Generic;

namespace Domain.Players
{
    public class CreatedPlayerDto
    {
        public Guid Id { get; private set; }
        public IList<string> Errors { get; set; }
        public bool IsValid { get; set; }

        public CreatedPlayerDto(Guid id)
        {
            Id = id;
            IsValid = true;

        }
        public CreatedPlayerDto(IList<string> errors)
        {
            Errors = errors;
            IsValid = false;
        }
    }
}
