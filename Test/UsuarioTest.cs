using Xunit;
using System.Collections.Generic;
using Domain.Users;

namespace Test
{
    public class UsuarioTest
    {
        [Fact]
        public void Deve_retornar_usuario()
        {
            // Dado / Setup
            //var campeonato = new Campeonato();
            var cbf = new User("Jenifer Pacini", true);
            var torcedor = new User("Afonso Padilha", false);
            
            // Quando / Ação
            var user = new List<User>{cbf,torcedor};

            // Deve / Asserções
            Assert.Equal("Jenifer Pacini",user[0].Name);
            Assert.Equal("Afonso Padilha",user[1].Name);
            Assert.True(user[0].CBF);
            Assert.False(user[1].CBF);
        }
    }
}
