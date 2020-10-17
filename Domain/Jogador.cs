using System;

namespace Domain
{
    public class Jogador
    {
        public Guid Id{get; private set;}
        public Time Time{get; set;}
        public string Nome{get; private set;}

        public Jogador (string nome)
        {
            this.Id =  new Guid();
            this.Nome = nome;
            this.Time = null;
        }
    }


}
