using Xunit;
using Domain.Teams;
using Domain.Players;

namespace Test
{
    public class TimeTest
    {
        [Fact]
        public void Deve_criar_time()
        {
            // Dado / Setup
            var pal = new Team("Palmeiras");
            
            // Quando / Ação

            // Deve / Asserções
            Assert.Equal("Palmeiras", pal.Name);
            Assert.Equal(0, pal.Players.Count);
            Assert.Equal(0, pal.Score);
            Assert.Equal(0, pal.MatchsPlayeds);
            Assert.Equal(0, pal.Wins);
            Assert.Equal(0, pal.Defeats);
            Assert.Equal(0, pal.Draws);
            Assert.Equal(0, pal.GoalsPro);
            Assert.Equal(0, pal.GoalsTaken);
            Assert.Equal(0, pal.GoalsScore);
        }

        [Fact]
        public void Deve_adicionar_Player()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");
            var kaka = new Player("kaka");
            var kellven = new Player("Kellven");
            
            // Quando / Ação
            palmeiras.AddPlayer(kaka);
            palmeiras.AddPlayer(kellven);

            // Deve / Asserções
            Assert.Equal("Palmeiras", palmeiras.Name);
            Assert.Equal(2, palmeiras.Players.Count);
            Assert.Equal("kaka", palmeiras.Players[0].Name);
            Assert.Equal("Kellven", palmeiras.Players[1].Name);
        
        }

        [Fact]
        public void Deve_remover_Player()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");
            var kaka = new Player("kaka");
            var kellven = new Player("Kellven");
            var kellven1 = new Player("Kellven1");
            var kellven2 = new Player("Kellven2");
            var kellven3 = new Player("Kellven3");
            var kellven4 = new Player("Kellven4");
            var kellven5 = new Player("Kellven5");
            var kellven6 = new Player("Kellven6");
            var kellven7 = new Player("Kellven7");
            var kellven8 = new Player("Kellven8");
            var kellven9 = new Player("Kellven9");
            var kellven10 = new Player("Kellven10");
            var kellven11 = new Player("Kellven11");
            var kellven12 = new Player("Kellven12");
            var kellven13 = new Player("Kellven13");
            var kellven14 = new Player("Kellven14");
            var kellven15 = new Player("Kellven15");
            var kellven16 = new Player("Kellven16");
            var kellven17 = new Player("Kellven17");
            var kellven18 = new Player("Kellven18");
            var kellven19 = new Player("Kellven19");
            var kellven20 = new Player("Kellven20");
            var kellven21 = new Player("Kellven21");
            var kellven22 = new Player("Kellven22");
            var kellven23 = new Player("Kellven23");
            var kellven24 = new Player("Kellven24");
            var kellven25 = new Player("Kellven25");
            var kellven26 = new Player("Kellven26");
            var kellven27 = new Player("Kellven27");
            var kellven28 = new Player("Kellven28");
            var kellven29 = new Player("Kellven29");
            var kellven30 = new Player("Kellven30");
            
            palmeiras.AddPlayer(kaka);
            palmeiras.AddPlayer(kellven);
            palmeiras.AddPlayer(kellven1);
            palmeiras.AddPlayer(kellven2);
            palmeiras.AddPlayer(kellven3);
            palmeiras.AddPlayer(kellven4);
            palmeiras.AddPlayer(kellven5);
            palmeiras.AddPlayer(kellven6);
            palmeiras.AddPlayer(kellven7);
            palmeiras.AddPlayer(kellven8);
            palmeiras.AddPlayer(kellven9);
            palmeiras.AddPlayer(kellven10);
            palmeiras.AddPlayer(kellven11);
            palmeiras.AddPlayer(kellven12);
            palmeiras.AddPlayer(kellven13);
            palmeiras.AddPlayer(kellven14);
            palmeiras.AddPlayer(kellven15);
            palmeiras.AddPlayer(kellven16);
            palmeiras.AddPlayer(kellven17);
            palmeiras.AddPlayer(kellven18);
            palmeiras.AddPlayer(kellven19);
            palmeiras.AddPlayer(kellven20);
            palmeiras.AddPlayer(kellven21);
            palmeiras.AddPlayer(kellven22);
            palmeiras.AddPlayer(kellven23);
            palmeiras.AddPlayer(kellven24);
            palmeiras.AddPlayer(kellven25);
            palmeiras.AddPlayer(kellven26);
            palmeiras.AddPlayer(kellven27);
            palmeiras.AddPlayer(kellven28);
            palmeiras.AddPlayer(kellven29);
            palmeiras.AddPlayer(kellven30);

            // Quando / Ação
            palmeiras.RemovePlayer(kaka);

            // Deve / Asserções
            Assert.Equal(31, palmeiras.Players.Count);
            Assert.Equal("Kellven", palmeiras.Players[0].Name);
            Assert.Equal("Kellven1", palmeiras.Players[1].Name);
        
        }
        
        [Fact]
        public void Nao_Deve_remover_Player()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");
            var kaka = new Player("kaka");
            var kellven = new Player("Kellven");
            var kellven1 = new Player("kellven1");
            var kellven2 = new Player("kellven2");
            var kellven3 = new Player("kellven3");
            var kellven4 = new Player("kellven4");
            var kellven5 = new Player("kellven5");
            var kellven6 = new Player("kellven6");
            var kellven7 = new Player("kellven7");
            var kellven8 = new Player("kellven8");
            var kellven9 = new Player("Kellven9");
            var kellven10 = new Player("Kellven10");
            var kellven11 = new Player("Kellven11");
            var kellven12 = new Player("Kellven12");
            var kellven13 = new Player("Kellven13");
            var kellven14 = new Player("Kellven14");

            palmeiras.AddPlayer(kaka);
            palmeiras.AddPlayer(kellven);
            palmeiras.AddPlayer(kellven1);
            palmeiras.AddPlayer(kellven2);
            palmeiras.AddPlayer(kellven3);
            palmeiras.AddPlayer(kellven4);
            palmeiras.AddPlayer(kellven5);
            palmeiras.AddPlayer(kellven6);
            palmeiras.AddPlayer(kellven7);
            palmeiras.AddPlayer(kellven8);
            palmeiras.AddPlayer(kellven9);
            palmeiras.AddPlayer(kellven10);
            palmeiras.AddPlayer(kellven11);
            palmeiras.AddPlayer(kellven12);
            palmeiras.AddPlayer(kellven13);
            palmeiras.AddPlayer(kellven14);
            
            // Quando / Ação
            palmeiras.RemovePlayer(kaka);

            // Deve / Asserções
            Assert.Equal(16, palmeiras.Players.Count);
            Assert.Equal("kaka", palmeiras.Players[0].Name);
            Assert.Equal("Kellven", palmeiras.Players[1].Name);
        }

        [Fact]
        public void Nao_Deve_Adicionar_Player()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");
            var kaka = new Player("kaka");
            var kellven = new Player("Kellven");
            var kellven1 = new Player("Kellven1");
            var kellven2 = new Player("Kellven2");
            var kellven3 = new Player("Kellven3");
            var kellven4 = new Player("Kellven4");
            var kellven5 = new Player("Kellven5");
            var kellven6 = new Player("Kellven6");
            var kellven7 = new Player("Kellven7");
            var kellven8 = new Player("Kellven8");
            var kellven9 = new Player("Kellven9");
            var kellven10 = new Player("Kellven10");
            var kellven11 = new Player("Kellven11");
            var kellven12 = new Player("Kellven12");
            var kellven13 = new Player("Kellven13");
            var kellven14 = new Player("Kellven14");
            var kellven15 = new Player("Kellven15");
            var kellven16 = new Player("Kellven16");
            var kellven17 = new Player("Kellven17");
            var kellven18 = new Player("Kellven18");
            var kellven19 = new Player("Kellven19");
            var kellven20 = new Player("Kellven20");
            var kellven21 = new Player("Kellven21");
            var kellven22 = new Player("Kellven22");
            var kellven23 = new Player("Kellven23");
            var kellven24 = new Player("Kellven24");
            var kellven25 = new Player("Kellven25");
            var kellven26 = new Player("Kellven26");
            var kellven27 = new Player("Kellven27");
            var kellven28 = new Player("Kellven28");
            var kellven29 = new Player("Kellven29");
            var kellven30 = new Player("Kellven30");
            var afonso = new Player("Afonso Padilha");
            
            palmeiras.AddPlayer(kaka);
            palmeiras.AddPlayer(kellven);
            palmeiras.AddPlayer(kellven1);
            palmeiras.AddPlayer(kellven2);
            palmeiras.AddPlayer(kellven3);
            palmeiras.AddPlayer(kellven4);
            palmeiras.AddPlayer(kellven5);
            palmeiras.AddPlayer(kellven6);
            palmeiras.AddPlayer(kellven7);
            palmeiras.AddPlayer(kellven8);
            palmeiras.AddPlayer(kellven9);
            palmeiras.AddPlayer(kellven10);
            palmeiras.AddPlayer(kellven11);
            palmeiras.AddPlayer(kellven12);
            palmeiras.AddPlayer(kellven13);
            palmeiras.AddPlayer(kellven14);
            palmeiras.AddPlayer(kellven15);
            palmeiras.AddPlayer(kellven16);
            palmeiras.AddPlayer(kellven17);
            palmeiras.AddPlayer(kellven18);
            palmeiras.AddPlayer(kellven19);
            palmeiras.AddPlayer(kellven20);
            palmeiras.AddPlayer(kellven21);
            palmeiras.AddPlayer(kellven22);
            palmeiras.AddPlayer(kellven23);
            palmeiras.AddPlayer(kellven24);
            palmeiras.AddPlayer(kellven25);
            palmeiras.AddPlayer(kellven26);
            palmeiras.AddPlayer(kellven27);
            palmeiras.AddPlayer(kellven28);
            palmeiras.AddPlayer(kellven29);
            palmeiras.AddPlayer(kellven30);

            // Quando / Ação
            palmeiras.AddPlayer(afonso);

            // Deve / Asserções
            Assert.Equal(32, palmeiras.Players.Count);
        }

        [Fact]
        public void Deve_Adicionar_2_gols_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");

            // Quando / Ação
            palmeiras.AddGoal();
            palmeiras.AddGoal();

            // Deve / Asserções
            Assert.Equal(2, palmeiras.GoalsPro);
        }
            [Fact]
        public void Deve_Adicionar_vitoria_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");

            // Quando / Ação
            palmeiras.AddWin();

            // Deve / Asserções
            Assert.Equal(1, palmeiras.Wins);
        }

        [Fact]
        public void Deve_Adicionar_derrota_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");

            // Quando / Ação
            palmeiras.AddDefeat();

            // Deve / Asserções
            Assert.Equal(1, palmeiras.Defeats);
        }
        
        [Fact]
        public void Deve_Levar_3_Gols_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");

            // Quando / Ação
            palmeiras.TakeGoal();
            palmeiras.TakeGoal();
            palmeiras.TakeGoal();

            // Deve / Asserções
            Assert.Equal(3, palmeiras.GoalsTaken);
        }

         [Fact]
        public void Deve_adicionar_empate_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Team("Palmeiras");

            // Quando / Ação
            palmeiras.AddDraw();

            // Deve / Asserções
            Assert.Equal(1, palmeiras.Draws);
        }
    }
}
