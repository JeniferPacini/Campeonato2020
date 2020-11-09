using System;
using Domain.Jogadores;

namespace Domain
{
    public class Gol
    {
        public Time Time {get; private set;}
        public Jogador Jogador {get; private set;}       
        public bool Contra {get; private set;}

        public Gol (Jogador jogador, bool contra)
        {
            this.Time = jogador.Time;
            this.Jogador = jogador;
            this.Contra = contra;
        }
    }
}
