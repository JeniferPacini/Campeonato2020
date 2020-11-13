using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Players;

namespace Domain.Teams
{
    public class Team
    {
        //Pontuação; Partidas disputadas; Vitórias; Empates; Derrotas; Saldo de gols; Gols pró; Gols contra; Porcentagem de aproveitamento
        public Guid Id {get; private set;}
        public string Name {get; private set;}
        public List<Player> Players {get; private set;}
        public int Score {get; private set;} = 0;
        public int MatchsPlayeds {get; private set;} = 0;
        public int Wins {get; private set;} = 0;
        public int Defeats {get; private set;} = 0;
        public int Draws {get; private set;} = 0;
        public int GoalsPro {get; private set;} = 0;
        public int GoalsTaken {get; private set;} = 0;
        public bool IsValid {get; private set;} = false;
        public int GoalsScore 
        { 
            get { return GoalsPro - GoalsTaken; }
        }
        public double PorcentagemAproveitamento
        { 
            get { return ((Score * 100) / (MatchsPlayeds * 3)); }
        }

        public Team (string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Players = new List<Player>();
        }

        public bool AddPlayer(Player player)
        {
            if((this.Players.Count == 32) || (player.Team != null))
            {
                return false;
            }
            player.Team = this;
            this.Players.Add(player);
            return true;
        }

        public bool RemovePlayer(Player player)
        {
            if(this.Players.Count <= 16)
            {
                return false;
            }
            this.Players.Remove(player);
            player.Team = null;
            return true;
        }

        public void AddGoal()
        {
            GoalsPro++;
        }

        public void TakeGoal()
        {
            GoalsTaken++;
        }

        public void AddWin()
        {
            Wins++;
            MatchsPlayeds++;
            Score += 3;
        }

        public void AddDefeat()
        {
            Defeats++;
            MatchsPlayeds++;
        }

        public void AddDraw()
        {
            Draws++;
            Score++;
            MatchsPlayeds++;
        }

        private bool ValidateName()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }

            if (Name.Any(x => !char.IsLetter(x)))
            {
                return false;
            }

            return true;
        }
    
        public (IList<string> errors, bool isValid) Validate()
        {
            var errors = new List<string>();
            if (!ValidateName())
            {
                errors.Add("Nome inválido.");
            }
            return (errors, errors.Count == 0);
        }

        private void ValidateTeam(Team team)
        {
            if(team.Players.Count >= 16 && team.Players.Count <= 32)
            {
                team.IsValid = true;
            }
            
        }
    }
}
