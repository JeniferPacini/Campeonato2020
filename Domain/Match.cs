using System;
using Domain.Players;
using Domain.Teams;

namespace Domain
{
    public class Match 
    {
        public Guid Id {get; private set;}
        public Team HomeTeam {get; private set;}
        public Team VisitingTeam {get; private set;}
        public int GoalsHomeTeam {get; private set;} = 0;
        public int GoalsVisitingTeam {get; private set;} = 0;

        public Match (Team homeTeam, Team visitingTeam)
        {
            this.Id = Guid.NewGuid();
            this.HomeTeam = homeTeam;
            this.VisitingTeam = visitingTeam;
        }

        public void AdicionarGol(Player player, bool against)
        {
            if(player.Team.Id == HomeTeam.Id)
            { 
                if(!against)
                {
                    this.GoalsHomeTeam++;
                    VisitingTeam.TakeGoal();
                    player.Team.AddGoal();
                    player.AddGoal(); 
                } 
                else
                {
                    this.GoalsVisitingTeam++;
                    VisitingTeam.AddGoal();
                    HomeTeam.TakeGoal();
                    player.AddGoalAgainst();
                }   
            }
            else
            {
                if(!against)
                {
                    this.GoalsVisitingTeam++;
                    HomeTeam.TakeGoal();
                    player.Team.AddGoal();
                    player.AddGoal(); 
                } 
                else
                {
                    this.GoalsHomeTeam++;
                    HomeTeam.AddGoal();
                    VisitingTeam.TakeGoal();
                    player.AddGoalAgainst();
                }   

            }
        }
        public void ProcessarResultado()
        {
            
            if( GoalsHomeTeam > GoalsVisitingTeam )
            {
                this.HomeTeam.AddWin();
                this.VisitingTeam.AddDefeat();
            }
            if( GoalsHomeTeam < GoalsVisitingTeam )
            {
                this.VisitingTeam.AddWin();
                this.HomeTeam.AddDefeat();
            }
            else
            {
                this.HomeTeam.AddDraw();
                this.VisitingTeam.AddDraw();
            }
            
        }

    }


}
