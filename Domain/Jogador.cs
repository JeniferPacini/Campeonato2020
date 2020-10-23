using System;

namespace Domain
{
    public class Jogador
    {
        public Guid Id{get; private set;}
        public Time Time{get; set;}
        public string Nome{get; private set;}
        public int GolsJogador{get; private set;}
        public int GolsContra{get; private set;}

        public Jogador (string nome)
        {
            this.Id =  new Guid();
            this.Nome = nome;
            this.Time = null;
            this.GolsJogador = 0;
            this.GolsContra = 0;
        }

        public void AdicionarGol()
        {
            GolsJogador++;
        }

        public void FazGolContra()
        {
            GolsContra++;
        }
    }
}
