using System;

namespace Domain
{
    public class Gol
    {
        public Time Time {get; private set;}
        public Jogador Jogador {get; private set;}

        public Gol (Jogador jogador, bool contra)
        {
            this.Time = jogador.Time;
            this.Jogador = jogador;
        }
    }
}
