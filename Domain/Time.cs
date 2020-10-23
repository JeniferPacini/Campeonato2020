using System;
using System.Collections.Generic;

namespace Domain
{
    public class Time
    {
        //Pontuação; Partidas disputadas; Vitórias; Empates; Derrotas; Saldo de gols; Gols pró; Gols contra; Porcentagem de aproveitamento
        public Guid Id {get; private set;}
        public string Nome {get; private set;}
        public List<Jogador> Jogadores {get; private set;}
        public int Pontuacao {get; private set;} = 0;
        public int PartidasDisputadas {get; private set;} = 0;
        public int Vitorias {get; private set;} = 0;
        public int Derrotas {get; private set;} = 0;
        public int Empates {get; private set;} = 0;
        public int GolsPro {get; private set;} = 0;
        public int GolsContra {get; private set;} = 0;
        public int SaldoGols 
        { 
            get { return GolsPro - GolsContra; }
        }
        public double PorcentagemAproveitamento
        { 
            get { return ((Pontuacao * 100) / (PartidasDisputadas * 3)); }
        }

        public Time (string nome)
        {
            this.Id =  new Guid();
            this.Nome = nome;
            this.Jogadores = new List<Jogador>();
        }

        public bool AdicionarJogador(Jogador jogador)
        {
            if((this.Jogadores.Count == 32) || (jogador.Time != null))
            {
                return false;
            }
            jogador.Time = this;
            this.Jogadores.Add(jogador);
            return true;
        }

        public bool RemoverJogador(Jogador jogador)
        {
            if(this.Jogadores.Count <= 16)
            {
                return false;
            }
            this.Jogadores.Remove(jogador);
            jogador.Time = null;
            return true;
        }

        public void AdicionarGol()
        {
            GolsPro++;
        }

        public void LevarGol()
        {
            GolsContra++;
        }

        public void ReceberVitoria()
        {
            Vitorias++;
            PartidasDisputadas++;
            Pontuacao += 3;
        }

        public void AdicionarDerrotas()
        {
            Derrotas++;
            PartidasDisputadas++;
        }

        public void AdicionarEmpate()
        {
            Empates++;
            Pontuacao++;
            PartidasDisputadas++;
        }
    }
}
