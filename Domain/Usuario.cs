using System;

namespace Domain
{
    public class Usuario
    {
        public Guid Id{get; private set;}
        public string Nome{get; private set;}
        public bool CBF{get; private set;}

        public Usuario (string nome, bool cbf)
        {
            this.Id =  new Guid();
            this.Nome = nome;
            this.CBF = cbf; 
        }

        
    }


}
