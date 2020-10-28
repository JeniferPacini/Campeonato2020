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
            
            // Quando / Ação
            var usuario = new List<Usuario>{cbf,torcedor};

            // Deve / Asserções
            Assert.Equal("Jenifer Pacini",usuario[0].Nome);
            Assert.Equal("Afonso Padilha",usuario[1].Nome);
            Assert.True(usuario[0].CBF);
            Assert.False(usuario[1].CBF);
        }
    }
}
