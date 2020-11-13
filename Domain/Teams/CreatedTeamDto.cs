using System;
using System.Collections.Generic;

namespace Domain.Teams
{
    public class CreatedTeamDto
    {
        public Guid Id { get; private set; }
        public IList<string> Errors { get; set; }
        public bool IsValid { get; set; }

        public CreatedTeamDto(Guid id)
        {
            Id = id;
            IsValid = true;

        }
        public CreatedTeamDto(IList<string> errors)
        {
            Errors = errors;
            IsValid = false;
        }
    }
}
