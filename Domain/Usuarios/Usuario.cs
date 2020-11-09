using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Usuarios
{
    public class Usuario
    {
        public Guid Id{get; private set;}
        public string Nome{get; private set;}
        public bool CBF{get; private set;}

        public Usuario (string nome, bool cbf)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.CBF = cbf; 
        }

        private bool ValidarNome()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }

            var words = Nome.Split(' ');
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
    
        public (IList<string> erros, bool valido) Validar()
        {
            var erros = new List<string>();
            if (!ValidarNome())
            {
                erros.Add("Nome inválido.");
            }
            return (erros, erros.Count == 0);
        }
    }
}
