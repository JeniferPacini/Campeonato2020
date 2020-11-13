using System;
using System.Collections.Generic;

namespace Domain.Teams
{
    public class TeamsRepository
    {
        private static List<Team> _teams = new List<Team>();
        public static IReadOnlyCollection<Team> Teams => _teams;

        public static void Add(Team team)
        {
            
            _teams.Add(team);
        }
    }
}
