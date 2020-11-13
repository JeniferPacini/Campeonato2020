using Xunit;
using Domain;
using Domain.Teams;

namespace Test
{
    public class ConfrontoTest
    {
        [Fact]
        public void Deve_criar_confronto()
        {
            // Dado / Setup
            var pal = new Team("Palmeiras");
            var sao = new Team("São Paulo");
            var san = new Team("Santos");
            var flu = new Team("Fluminense");
            var fla = new Team("Flamengo");
            var cor = new Team("Corintians");
            
            // Quando / Ação
            var match = new Match(pal,sao);

            // Deve / Asserções
            Assert.Equal("Palmeiras", match.HomeTeam.Name);
            Assert.Equal("São Paulo", match.VisitingTeam.Name);
            Assert.Equal(0, match.GoalsHomeTeam);
            Assert.Equal(0, match.GoalsVisitingTeam);
        }
    }
}
