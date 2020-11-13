using System;
using Domain.Players;
using Domain.Teams;

namespace Domain
{
    public class Goal
    {
        public Team Team {get; private set;}
        public Player Player {get; private set;}       
        public bool Against {get; private set;}

        public Goal (Player player, bool against)
        {
            this.Team = player.Team;
            this.Player = player;
            this.Against = against;
        }
    }
}
