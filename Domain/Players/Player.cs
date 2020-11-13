using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Teams;

namespace Domain.Players
{
    public class Player
    {
        public Guid Id {get; private set;}
        public Team Team {get; set;}
        public string Name {get; private set;}
        public int Goals {get; private set;}
        public int GoalsAgainst {get; private set;}

        public Player (string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Team = null;
            this.Goals= 0;
            this.GoalsAgainst = 0;
        }

        private bool ValidateName()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }

            var words = Name.Split(' ');
            if (words.Length < 2)
            {
                return false;
            }

            foreach (var word in words)
            {
                if (word.Trim().Length < 2)
                {
                    return false;
                }
                if (word.Any(x => !char.IsLetter(x)))
                {
                    return false;
                }
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

        public void AddGoal()
        {
            Goals++;
        }

        public void AddGoalAgainst()
        {
            GoalsAgainst++;
        }
    }
}
