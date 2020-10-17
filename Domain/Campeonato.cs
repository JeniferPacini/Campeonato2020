using System;
using System.Collections.Generic;

namespace Domain
{
    public class Campeonato
    {
        public Guid Id{get; private set;}
        public string Nome{get; private set;}
        public List<Confronto> Confrontos {get; private set;}
        public List<Time> Times {get; private set;}

        public Campeonato (string nome)
        {
            this.Id =  new Guid();
            this.Nome = nome;
            this.Confrontos = new List<Confronto>();
            this.Times = new List<Time>();
        }

        public void AddConfronto(Time timeCasa, Time timeVisitante)
        {
            Confronto confronto = new Confronto(timeCasa, timeVisitante);
            this.Confrontos.Add(confronto);
        }
        
        public void AddTime(string nome)
        {
            Time time = new Time(nome);
            this.Times.Add(time);
        }

        public bool GerarConfrontos()
        {
            if(this.Times.Count < 8)
            {
                return false;
            }
            for(int i = 0; i < this.Times.Count; i++)
            {
                for(int j = 0; j < this.Times.Count; j++)
                {
                    if(this.Times[i].Id != this.Times[j].Id)
                    {
                        AddConfronto(this.Times[i],this.Times[j]);
                    }
                }
            }
            return true;
        }


        
    }
}
