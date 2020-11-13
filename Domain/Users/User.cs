using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Users
{
    public class User
    {
        public Guid Id{get; private set;}
        public string Name{get; private set;}
        public bool CBF{get; private set;}

        public User (string nome, bool cbf)
        {
            this.Id = Guid.NewGuid();
            this.Name = nome;
            this.CBF = cbf; 
        }

        private bool ValidateNome()
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
            if (!ValidateNome())
            {
                errors.Add("Nome inválido.");
            }
            return (errors, errors.Count == 0);
        }
    }
}
