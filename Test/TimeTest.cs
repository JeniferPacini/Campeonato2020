using System;
using Xunit;
using Domain;
using System.Collections.Generic;

namespace Test
{
    public class TimeTest
    {
        [Fact]
        public void Deve_criar_time()
        {
            // Dado / Setup
            var pal = new Time("Palmeiras");
            
            // Quando / Ação

            // Deve / Asserções
            Assert.Equal("Palmeiras", pal.Nome);
            Assert.Equal(0, pal.Jogadores.Count);
            Assert.Equal(0, pal.Pontuacao);
            Assert.Equal(0, pal.PartidasDisputadas);
            Assert.Equal(0, pal.Vitorias);
            Assert.Equal(0, pal.Derrotas);
            Assert.Equal(0, pal.Empates);
            Assert.Equal(0, pal.GolsPro);
            Assert.Equal(0, pal.GolsContra);
            Assert.Equal(0, pal.SaldoGols);
        }

        [Fact]
        public void Deve_adicionar_jogador()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");
            var kaka = new Jogador("kaka");
            var kellven = new Jogador("Kellven");
            
            // Quando / Ação
            palmeiras.AdicionarJogador(kaka);
            palmeiras.AdicionarJogador(kellven);

            // Deve / Asserções
            Assert.Equal("Palmeiras", palmeiras.Nome);
            Assert.Equal(2, palmeiras.Jogadores.Count);
            Assert.Equal("kaka", palmeiras.Jogadores[0].Nome);
            Assert.Equal("Kellven", palmeiras.Jogadores[1].Nome);
        
        }

        [Fact]
        public void Deve_remover_jogador()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");
            var kaka = new Jogador("kaka");
            var kellven = new Jogador("Kellven");
            var kellven1 = new Jogador("Kellven1");
            var kellven2 = new Jogador("Kellven2");
            var kellven3 = new Jogador("Kellven3");
            var kellven4 = new Jogador("Kellven4");
            var kellven5 = new Jogador("Kellven5");
            var kellven6 = new Jogador("Kellven6");
            var kellven7 = new Jogador("Kellven7");
            var kellven8 = new Jogador("Kellven8");
            var kellven9 = new Jogador("Kellven9");
            var kellven10 = new Jogador("Kellven10");
            var kellven11 = new Jogador("Kellven11");
            var kellven12 = new Jogador("Kellven12");
            var kellven13 = new Jogador("Kellven13");
            var kellven14 = new Jogador("Kellven14");
            var kellven15 = new Jogador("Kellven15");
            var kellven16 = new Jogador("Kellven16");
            var kellven17 = new Jogador("Kellven17");
            var kellven18 = new Jogador("Kellven18");
            var kellven19 = new Jogador("Kellven19");
            var kellven20 = new Jogador("Kellven20");
            var kellven21 = new Jogador("Kellven21");
            var kellven22 = new Jogador("Kellven22");
            var kellven23 = new Jogador("Kellven23");
            var kellven24 = new Jogador("Kellven24");
            var kellven25 = new Jogador("Kellven25");
            var kellven26 = new Jogador("Kellven26");
            var kellven27 = new Jogador("Kellven27");
            var kellven28 = new Jogador("Kellven28");
            var kellven29 = new Jogador("Kellven29");
            var kellven30 = new Jogador("Kellven30");
            
            palmeiras.AdicionarJogador(kaka);
            palmeiras.AdicionarJogador(kellven);
            palmeiras.AdicionarJogador(kellven1);
            palmeiras.AdicionarJogador(kellven2);
            palmeiras.AdicionarJogador(kellven3);
            palmeiras.AdicionarJogador(kellven4);
            palmeiras.AdicionarJogador(kellven5);
            palmeiras.AdicionarJogador(kellven6);
            palmeiras.AdicionarJogador(kellven7);
            palmeiras.AdicionarJogador(kellven8);
            palmeiras.AdicionarJogador(kellven9);
            palmeiras.AdicionarJogador(kellven10);
            palmeiras.AdicionarJogador(kellven11);
            palmeiras.AdicionarJogador(kellven12);
            palmeiras.AdicionarJogador(kellven13);
            palmeiras.AdicionarJogador(kellven14);
            palmeiras.AdicionarJogador(kellven15);
            palmeiras.AdicionarJogador(kellven16);
            palmeiras.AdicionarJogador(kellven17);
            palmeiras.AdicionarJogador(kellven18);
            palmeiras.AdicionarJogador(kellven19);
            palmeiras.AdicionarJogador(kellven20);
            palmeiras.AdicionarJogador(kellven21);
            palmeiras.AdicionarJogador(kellven22);
            palmeiras.AdicionarJogador(kellven23);
            palmeiras.AdicionarJogador(kellven24);
            palmeiras.AdicionarJogador(kellven25);
            palmeiras.AdicionarJogador(kellven26);
            palmeiras.AdicionarJogador(kellven27);
            palmeiras.AdicionarJogador(kellven28);
            palmeiras.AdicionarJogador(kellven29);
            palmeiras.AdicionarJogador(kellven30);

            // Quando / Ação
            palmeiras.RemoverJogador(kaka);

            // Deve / Asserções
            Assert.Equal(31, palmeiras.Jogadores.Count);
            Assert.Equal("Kellven", palmeiras.Jogadores[0].Nome);
            Assert.Equal("Kellven1", palmeiras.Jogadores[1].Nome);
        
        }
        
        [Fact]
        public void Nao_Deve_remover_jogador()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");
            var kaka = new Jogador("kaka");
            var kellven = new Jogador("Kellven");
            var kellven1 = new Jogador("kellven1");
            var kellven2 = new Jogador("kellven2");
            var kellven3 = new Jogador("kellven3");
            var kellven4 = new Jogador("kellven4");
            var kellven5 = new Jogador("kellven5");
            var kellven6 = new Jogador("kellven6");
            var kellven7 = new Jogador("kellven7");
            var kellven8 = new Jogador("kellven8");
            var kellven9 = new Jogador("Kellven9");
            var kellven10 = new Jogador("Kellven10");
            var kellven11 = new Jogador("Kellven11");
            var kellven12 = new Jogador("Kellven12");
            var kellven13 = new Jogador("Kellven13");
            var kellven14 = new Jogador("Kellven14");

            palmeiras.AdicionarJogador(kaka);
            palmeiras.AdicionarJogador(kellven);
            palmeiras.AdicionarJogador(kellven1);
            palmeiras.AdicionarJogador(kellven2);
            palmeiras.AdicionarJogador(kellven3);
            palmeiras.AdicionarJogador(kellven4);
            palmeiras.AdicionarJogador(kellven5);
            palmeiras.AdicionarJogador(kellven6);
            palmeiras.AdicionarJogador(kellven7);
            palmeiras.AdicionarJogador(kellven8);
            palmeiras.AdicionarJogador(kellven9);
            palmeiras.AdicionarJogador(kellven10);
            palmeiras.AdicionarJogador(kellven11);
            palmeiras.AdicionarJogador(kellven12);
            palmeiras.AdicionarJogador(kellven13);
            palmeiras.AdicionarJogador(kellven14);
            
            // Quando / Ação
            palmeiras.RemoverJogador(kaka);

            // Deve / Asserções
            Assert.Equal(16, palmeiras.Jogadores.Count);
            Assert.Equal("kaka", palmeiras.Jogadores[0].Nome);
            Assert.Equal("Kellven", palmeiras.Jogadores[1].Nome);
        }

        [Fact]
        public void Nao_Deve_Adicionar_jogador()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");
            var kaka = new Jogador("kaka");
            var kellven = new Jogador("Kellven");
            var kellven1 = new Jogador("Kellven1");
            var kellven2 = new Jogador("Kellven2");
            var kellven3 = new Jogador("Kellven3");
            var kellven4 = new Jogador("Kellven4");
            var kellven5 = new Jogador("Kellven5");
            var kellven6 = new Jogador("Kellven6");
            var kellven7 = new Jogador("Kellven7");
            var kellven8 = new Jogador("Kellven8");
            var kellven9 = new Jogador("Kellven9");
            var kellven10 = new Jogador("Kellven10");
            var kellven11 = new Jogador("Kellven11");
            var kellven12 = new Jogador("Kellven12");
            var kellven13 = new Jogador("Kellven13");
            var kellven14 = new Jogador("Kellven14");
            var kellven15 = new Jogador("Kellven15");
            var kellven16 = new Jogador("Kellven16");
            var kellven17 = new Jogador("Kellven17");
            var kellven18 = new Jogador("Kellven18");
            var kellven19 = new Jogador("Kellven19");
            var kellven20 = new Jogador("Kellven20");
            var kellven21 = new Jogador("Kellven21");
            var kellven22 = new Jogador("Kellven22");
            var kellven23 = new Jogador("Kellven23");
            var kellven24 = new Jogador("Kellven24");
            var kellven25 = new Jogador("Kellven25");
            var kellven26 = new Jogador("Kellven26");
            var kellven27 = new Jogador("Kellven27");
            var kellven28 = new Jogador("Kellven28");
            var kellven29 = new Jogador("Kellven29");
            var kellven30 = new Jogador("Kellven30");
            var afonso = new Jogador("Afonso Padilha");
            
            palmeiras.AdicionarJogador(kaka);
            palmeiras.AdicionarJogador(kellven);
            palmeiras.AdicionarJogador(kellven1);
            palmeiras.AdicionarJogador(kellven2);
            palmeiras.AdicionarJogador(kellven3);
            palmeiras.AdicionarJogador(kellven4);
            palmeiras.AdicionarJogador(kellven5);
            palmeiras.AdicionarJogador(kellven6);
            palmeiras.AdicionarJogador(kellven7);
            palmeiras.AdicionarJogador(kellven8);
            palmeiras.AdicionarJogador(kellven9);
            palmeiras.AdicionarJogador(kellven10);
            palmeiras.AdicionarJogador(kellven11);
            palmeiras.AdicionarJogador(kellven12);
            palmeiras.AdicionarJogador(kellven13);
            palmeiras.AdicionarJogador(kellven14);
            palmeiras.AdicionarJogador(kellven15);
            palmeiras.AdicionarJogador(kellven16);
            palmeiras.AdicionarJogador(kellven17);
            palmeiras.AdicionarJogador(kellven18);
            palmeiras.AdicionarJogador(kellven19);
            palmeiras.AdicionarJogador(kellven20);
            palmeiras.AdicionarJogador(kellven21);
            palmeiras.AdicionarJogador(kellven22);
            palmeiras.AdicionarJogador(kellven23);
            palmeiras.AdicionarJogador(kellven24);
            palmeiras.AdicionarJogador(kellven25);
            palmeiras.AdicionarJogador(kellven26);
            palmeiras.AdicionarJogador(kellven27);
            palmeiras.AdicionarJogador(kellven28);
            palmeiras.AdicionarJogador(kellven29);
            palmeiras.AdicionarJogador(kellven30);

            // Quando / Ação
            palmeiras.AdicionarJogador(afonso);

            // Deve / Asserções
            Assert.Equal(32, palmeiras.Jogadores.Count);
        }

        [Fact]
        public void Deve_Adicionar_2_gols_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");

            // Quando / Ação
            palmeiras.AdicionarGol();
            palmeiras.AdicionarGol();

            // Deve / Asserções
            Assert.Equal(2, palmeiras.GolsPro);
        }
            [Fact]
        public void Deve_Adicionar_vitoria_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");

            // Quando / Ação
            palmeiras.ReceberVitoria();

            // Deve / Asserções
            Assert.Equal(1, palmeiras.Vitorias);
        }

        [Fact]
        public void Deve_Adicionar_derrota_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");

            // Quando / Ação
            palmeiras.AdicionarDerrotas();

            // Deve / Asserções
            Assert.Equal(1, palmeiras.Derrotas);
        }
        
        [Fact]
        public void Deve_Levar_3_Gols_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");

            // Quando / Ação
            palmeiras.LevarGol();
            palmeiras.LevarGol();
            palmeiras.LevarGol();

            // Deve / Asserções
            Assert.Equal(3, palmeiras.GolsContra);
        }

         [Fact]
        public void Deve_adicionar_empate_para_palmeiras()
        {
            // Dado / Setup
            var palmeiras = new Time("Palmeiras");

            // Quando / Ação
            palmeiras.AdicionarEmpate();

            // Deve / Asserções
            Assert.Equal(1, palmeiras.Empates);
        }
    }
}
