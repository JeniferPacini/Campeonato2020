using System;
using System.Linq;

namespace Domain.Teams
{
    public class TeamsService
    {
        public CreatedTeamDto Create(string name)
        {
            var team = new Team(name);
            var validateTeam = team.Validate();

            if(validateTeam.isValid)
            {
                TeamsRepository.Add(team);
                return new CreatedTeamDto(team.Id);
            }

            return new CreatedTeamDto(validateTeam.errors);
        }
    }
}
