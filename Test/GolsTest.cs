using System;
using Xunit;
using Domain;
using System.Collections.Generic;
using Domain.Players;

namespace Test
{
    public class GolsTest
    {
        [Fact]
        public void Deve_retornar_gols()
        {
            // Dado / Setup
            var santos = new Player("Santos");
            var vitor = new Player("Vitor");
            var kaka = new Player("Kaka");
            var goal1 = new Goal(santos,true);
            var goal2 = new Goal(vitor,false);
            var goal3 = new Goal(kaka,true);
            
            // Quando / Ação
            var goals = new List<Goal>{goal1,goal2,goal3};

            // Deve / Asserções
            Assert.Equal(3, goals.Count);
            Assert.Equal("Santos", goals[0].Player.Name);
            Assert.Equal("Vitor", goals[1].Player.Name);
            Assert.Equal("Kaka", goals[2].Player.Name);
            Assert.True(goals[0].Against);
            Assert.False(goals[1].Against);
            Assert.True(goals[2].Against);
        }
    }
}
