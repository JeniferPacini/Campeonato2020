using System;
using System.Collections.Generic;

namespace Domain
{
    public class Confronto 
    {
        public Guid Id {get; private set;}
        public Time TimeCasa {get; private set;}
        public Time TimeVisitante {get; private set;}
        public int GolsTimeCasa {get; private set;}
        public int GolsTimeVisitante {get; private set;}

        public Confronto (Time timeCasa, Time timeVisitante)
        {
            this.Id =  new Guid();
            this.TimeCasa = timeCasa;
            this.TimeVisitante = timeVisitante;
        }

        public void AdicionarGol(Jogador jogador, bool contra)
        {
            if(jogador.Time.Id == TimeCasa.Id)
            { 
                if(!contra)
                {
                    this.GolsTimeCasa++;
                    TimeVisitante.LevarGol();
                    jogador.Time.AdicionarGol();
                    jogador.AdicionarGol(); 
                } 
                else
                {
                    this.GolsTimeVisitante++;
                    TimeVisitante.AdicionarGol();
                    TimeCasa.LevarGol();
                    jogador.FazGolContra();
                }   
            }
            else
            {
                if(!contra)
                {
                    this.GolsTimeVisitante++;
                    TimeCasa.LevarGol();
                    jogador.Time.AdicionarGol();
                    jogador.AdicionarGol(); 
                } 
                else
                {
                    this.GolsTimeCasa++;
                    TimeCasa.AdicionarGol();
                    TimeVisitante.LevarGol();
                    jogador.FazGolContra();
                }   

            }
        }

        public void ProcessarResultado()
        {
            
            if( GolsTimeCasa > GolsTimeVisitante )
            {
                this.TimeCasa.Vitorias++;
                this.TimeCasa.Pontuacao += 3;
                this.TimeCasa.PartidasDisputadas++;

                this.TimeVisitante.PartidasDisputadas++;
                this.TimeVisitante.Derrotas++;
            }
            if( GolsTimeCasa < GolsTimeVisitante )
            {
                this.TimeVisitante.Vitorias++;
                this.TimeVisitante.Pontuacao += 3;
                this.TimeVisitante.PartidasDisputadas++;

                this.TimeCasa.PartidasDisputadas++;
                this.TimeCasa.Derrotas++;
            }
            else
            {
                this.TimeCasa.Pontuacao++;
                this.TimeCasa.Empates++;
                this.TimeCasa.PartidasDisputadas++;

                this.TimeVisitante.Pontuacao++;
                this.TimeVisitante.Empates++;
                this.TimeVisitante.PartidasDisputadas++;
            }
        }

    }


}
