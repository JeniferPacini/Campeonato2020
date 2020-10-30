using System;
using Xunit;
using Domain;
using System.Collections.Generic;

namespace Test
{
    public class ConfrontoTest
    {
        [Fact]
        public void Deve_criar_confronto()
        {
            // Dado / Setup
            var pal = new Time("Palmeiras");
            var sao = new Time("São Paulo");
            var san = new Time("Santos");
            var flu = new Time("Fluminense");
            var fla = new Time("Flamengo");
            var cor = new Time("Corintians");
            
            // Quando / Ação
            var confronto = new Confronto(pal,sao);

            // Deve / Asserções
            Assert.Equal("Palmeiras", confronto.TimeCasa.Nome);
            Assert.Equal("São Paulo", confronto.TimeVisitante.Nome);
            Assert.Equal(0, confronto.GolsTimeCasa);
            Assert.Equal(0, confronto.GolsTimeVisitante);
        }
    }
}
