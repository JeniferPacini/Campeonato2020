using System;
using Xunit;
using Domain;
using System.Collections.Generic;

namespace Test
{
    public class JogadorTest
    {
        [Fact]
        public void Deve_retornar_3_jogadores()
        {
            // Dado / Setup
            var santos = new Jogador("Santos");
            var vitor = new Jogador("Vitor");
            var kaka = new Jogador("Kaka");
            
            // Quando / Ação

            // Deve / Asserções
            Assert.Equal("Santos", santos.Nome);
            Assert.Equal("Vitor", vitor.Nome);
            Assert.Equal("Kaka", kaka.Nome);
            Assert.Null(santos.Time);
            Assert.Null(vitor.Time);
            Assert.Equal(0,santos.Gols);
            Assert.Equal(0,vitor.Gols);
            Assert.Equal(0,santos.GolsContra);
            Assert.Equal(0,vitor.GolsContra);
        }

        [Fact]
        public void Deve_adicionar_5_gols_para_kaka()
        {
            // Dado / Setup
            var kaka = new Jogador("Kaka");
            
            // Quando / Ação
            kaka.AdicionarGol();
            kaka.AdicionarGol();
            kaka.AdicionarGol();
            kaka.AdicionarGol();
            kaka.AdicionarGol();

            // Deve / Asserções
            Assert.Equal(5, kaka.Gols);
            Assert.Equal(0,kaka.GolsContra);
        }
    }
}
