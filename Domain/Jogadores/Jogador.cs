using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Jogadores
{
    public class Jogador
    {
        public Guid Id {get; private set;}
        public Time Time {get; set;}
        public string Nome {get; private set;}
        public int Gols {get; private set;}
        public int GolsContra {get; private set;}

        public Jogador (string nome)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Time = null;
            this.Gols= 0;
            this.GolsContra = 0;
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

        public void AdicionarGol()
        {
            Gols++;
        }

        public void AdicionarGolContra()
        {
            GolsContra++;
        }
    }
}
