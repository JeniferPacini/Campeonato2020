using System;
using Xunit;
using Domain;
using System.Collections.Generic;

namespace Test
{
    public class UsuarioTest
    {
        [Fact]
        public void Deve_retornar_usuario()
        {
            // Dado / Setup
            //var campeonato = new Campeonato();
            var cbf = new Usuario("Jenifer Pacini", true);
            var torcedor = new Usuario("Afonso Padilha", false);
            var usuario = new List<Usuario>{cbf,torcedor};

            Time[0].Jogador.Add()

            // var flu = new Time("Fluminense");
            // var sao = new Time("São Paulo");
            // var vas = new Time("Vasco");
            // var cor = new Time("Corintians");
            // var fla = new Time("Flamengo");
            // var pal = new Time("Palmeiras");
            // var bot = new Time("Botafogo");
            // var san = new Time("Santos");
            // var gre = new Time("Gremio");
            // var times = new List<Time>{flu,sao,vas,cor,fla,pal,san,gre};

            var cbf = new Usuario("Jenifer Pacini", true);
            var torcedor = new Usuario("Afonso Padilha", false);
            var usuario = new List<Usuario>{cbf,torcedor};

            // Quando / Ação
            var created = jogador.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
        }
    }
}
