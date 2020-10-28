using System;
using Xunit;
using Domain;
using System.Collections.Generic;

namespace Test
{
    public class GolsTest
    {
        [Fact]
        public void Deve_retornar_gols()
        {
            // Dado / Setup
            var santos = new Jogador("Santos");
            var vitor = new Jogador("Vitor");
            var kaka = new Jogador("Kaka");
            var gol1 = new Gol(santos,true);
            var gol2 = new Gol(vitor,false);
            var gol3 = new Gol(kaka,true);
            
            // Quando / Ação
            var gols = new List<Gol>{gol1,gol2,gol3};

            // Deve / Asserções
            Assert.Equal(3, gols.Count);
            Assert.Equal("Santos", gols[0].Jogador.Nome);
            Assert.Equal("Vitor", gols[1].Jogador.Nome);
            Assert.Equal("Kaka", gols[2].Jogador.Nome);
            Assert.True(gols[0].Contra);
            Assert.False(gols[1].Contra);
            Assert.True(gols[2].Contra);
        }
    }
}
