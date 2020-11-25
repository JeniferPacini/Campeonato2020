using System;
using System.Collections.Generic;
using Domain.Teams;

namespace Domain
{
    public class Championship
    {
        public Guid Id{get; private set;}
        public string Name{get; private set;}
        public List<Match> Matchs {get; private set;}
        public List<Team> Teams {get; private set;}
        public List<Team> Ranking {get; private set;}

        public Championship (string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Matchs = new List<Match>();
            this.Teams = new List<Team>();
            this.Ranking = new List<Team>();
        }

        private void AddMatch(Team homeTeam, Team visitingTeam)
        {
            Match match = new Match(homeTeam, visitingTeam);
            this.Matchs.Add(match);
        }
        
        public void AddTeam(Team team)
        {
            this.Teams.Add(team);
            this.Ranking.Add(team);
        }

        public bool GenerateMatch()
        {
            if(this.Teams.Count < 8)
            {
                return false;
            }

            var listTeams = new List<Team>();

            for (int i = 0; i < Teams.Count; i++)
            {
                if(Teams[i].IsValid)
                {
                    listTeams.Add(Teams[i]);
                }
            }

            if(listTeams.Count < 8)
            {
                return false;
            }

            for(int i = 0; i < listTeams.Count; i++)
            {
                for(var j = listTeams.Count-1; j >= 0; j--)
                {
                    if(listTeams[i].Id != listTeams[j].Id && listTeams[i] != null && listTeams[j] != null)
                    {
                        AddMatch(listTeams[i],listTeams[j]);
                        listTeams[i] = null;
                        listTeams[j] = null;
                    }
                }
            }
            return true;
        }

        public void FinishRound()
        {
            for(int i = 1; i < Teams.Count; i++)
            {
                for (int j = 0; j < Ranking.Count; j++)
                {
                    if(Teams[i].Score > Ranking[j].Score)
                    {
                        
                    }
                }
            }
        }
        
    }
}
