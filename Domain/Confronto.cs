using System;
using System.Collections.Generic;

namespace Domain
{
    public class Confronto 
    {
        public Guid Id {get; private set;}
        public Time TimeCasa {get; private set;}
        public Time TimeVisitante {get; private set;}
        public List<Gol> Gol {get; private set;}

        public Confronto (Time timeCasa, Time timeVisitante)
        {
            this.Id =  new Guid();
            this.TimeCasa = timeCasa;
            this.TimeVisitante = timeVisitante;
            this.Gol = new List<Gol>();
        }

        public void AddGol(Jogador jogador, bool contra)
        {
            Gol gol = new Gol(jogador,contra);
            this.Gol.Add(gol);
        }

        public void ProcessarResultado()
        {
            var golsTimeCasa = 0;
            var golsTimeVisitante = 0;
            for( int i = 0; i < this.Gol.Count; i++)
            {
                if( this.Gol[i].Time.Id == this.TimeCasa.Id )
                {
                    if(!this.Gol[i].Contra)
                    {
                        golsTimeCasa++;
                    }
                    else
                    {
                        golsTimeVisitante++;
                    }
                }
                else
                {
                    if(!this.Gol[i].Contra)
                    {
                        golsTimeVisitante++;
                    }
                    else
                    {
                        golsTimeCasa++;
                    }
                }
            }
            if( golsTimeCasa > golsTimeVisitante )
            {
                this.TimeCasa.Vitorias++;
                this.TimeCasa.Pontuacao += 3;
                this.TimeCasa.PartidasDisputadas++;
                this.TimeCasa.golsPro += golsTimeCasa;
                this.TimeCasa.golsContra += golsTimeVisitante;

                this.Timevisitante.PartidasDisputadas++;
                this.TimeVisitante.Derrotas++;
                this.TimeVisitante.golsPro += golsTimeVisitante;
                this.TimeVisitante.golsContra += golsTimeCasa;
            }
            if( golsTimeCasa < golsTimeVisitante )
            {
                this.TimeVisitante.Vitorias++;
                this.TimeVisitante.Pontuacao += 3;
                this.TimeVisitante.PartidasDisputadas++;
                this.TimeVisitante.golsPro += golsTimeVisitante;
                this.TimeVisitante.golsContra += golsTimeCasa;

                this.TimeCasa.PartidasDisputadas++;
                this.TimeCasa.Derrotas++;
                this.TimeCasa.golsPro += golsTimeCasa;
                this.TimeCasa.golsContra += golsTimeVisitante;
            }
            else
            {
                this.TimeCasa.Pontuacao++;
                this.TimeCasa.Empates++;
                this.TimeCasa.PartidasDisputadas++;
                this.TimeCasa.golsPro += golsTimeCasa;
                this.TimeCasa.golsContra += golsTimeVisitante;

                this.TimeVisitante.Pontuacao++;
                this.TimeVisitante.Empates++;
                this.TimeVisitante.PartidasDisputadas++;
                this.TimeVisitante.golsPro += golsTimeVisitante;
                this.TimeVisitante.golsContra += golsTimeCasa;
            }
        }

    }


}
