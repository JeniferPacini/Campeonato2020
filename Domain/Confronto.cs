using System;
using Domain.Jogadores;

namespace Domain
{
    public class Confronto 
    {
        public Guid Id {get; private set;}
        public Time TimeCasa {get; private set;}
        public Time TimeVisitante {get; private set;}
        public int GolsTimeCasa {get; private set;} = 0;
        public int GolsTimeVisitante {get; private set;} = 0;

        public Confronto (Time timeCasa, Time timeVisitante)
        {
            this.Id = Guid.NewGuid();
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
                    jogador.AdicionarGolContra();
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
                    jogador.AdicionarGolContra();
                }   

            }
        }
        public void ProcessarResultado()
        {
            
            if( GolsTimeCasa > GolsTimeVisitante )
            {
                this.TimeCasa.ReceberVitoria();
                this.TimeVisitante.AdicionarDerrotas();
            }
            if( GolsTimeCasa < GolsTimeVisitante )
            {
                this.TimeVisitante.ReceberVitoria();
                this.TimeCasa.AdicionarDerrotas();
            }
            else
            {
                this.TimeCasa.AdicionarEmpate();
                this.TimeVisitante.AdicionarEmpate();
            }
            
        }

    }


}
