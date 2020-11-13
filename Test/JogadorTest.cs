using System;
using Xunit;
using Domain;
using System.Collections.Generic;
using Domain.Players;

namespace Test
{
    public class JogadorTest
    {
        [Fact]
        public void Deve_retornar_3_jogadores()
        {
            // Dado / Setup
            var santos = new Player("Santos");
            var vitor = new Player("Vitor");
            var kaka = new Player("Kaka");
            
            // Quando / Ação

            // Deve / Asserções
            Assert.Equal("Santos", santos.Name);
            Assert.Equal("Vitor", vitor.Name);
            Assert.Equal("Kaka", kaka.Name);
            Assert.Null(santos.Team);
            Assert.Null(vitor.Team);
            Assert.Equal(0,santos.Goals);
            Assert.Equal(0,vitor.Goals);
            Assert.Equal(0,santos.GoalsAgainst);
            Assert.Equal(0,vitor.GoalsAgainst);
        }

        [Fact]
        public void Deve_adicionar_5_gols_para_kaka()
        {
            // Dado / Setup
            var kaka = new Player("Kaka");
            
            // Quando / Ação
            kaka.AddGoal();
            kaka.AddGoal();
            kaka.AddGoal();
            kaka.AddGoal();
            kaka.AddGoal();

            // Deve / Asserções
            Assert.Equal(5, kaka.Goals);
            Assert.Equal(0,kaka.GoalsAgainst);
        }

        [Fact]
        public void Deve_adicionar_2_gols_contra_para_kaka()
        {
            // Dado / Setup
            var kaka = new Player("Kaka");
            
            // Quando / Ação
            kaka.AddGoalAgainst();
            kaka.AddGoalAgainst();

            // Deve / Asserções
            Assert.Equal(2, kaka.GoalsAgainst);
            Assert.Equal(0,kaka.Goals);
        }
    }
}
