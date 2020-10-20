using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AdicionarConfronto(Time timeCasa, Time timeVisitante)
        {
            Confronto confronto = new Confronto(timeCasa, timeVisitante);
            this.Confrontos.Add(confronto);
        }
        
        public void AdicionarTime(string nome)
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
            var listaTimes = new Time[Times.Count];
            listaTimes.CopyTo(Times.ToArray(),0);
            for(int i = 0; i < listaTimes.Length; i++)
            {
                for(int j = 0; j < listaTimes.Length; j++)
                {
                    if(listaTimes[i].Id != listaTimes[j].Id && listaTimes[i] != null && listaTimes[j] != null)
                    {
                        AdicionarConfronto(listaTimes[i],listaTimes[j]);
                        listaTimes[i] = null;
                        listaTimes[j] = null;
                    }
                }
            }
            return true;
        }


        
    }
}
