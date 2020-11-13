using Xunit;
using Domain;
using System.Collections.Generic;
using Domain.Users;
using Domain.Teams;
using Domain.Players;

namespace Test
{
    public class CampeonatoTest
    {
        [Fact]
        public void Deve_retornar_usuario()
        {
            // Dado / Setup
            //var campeonato = new Campeonato();
            var cbf = new User("Jenifer Pacini", true);
            var torcedor = new User("Afonso Padilha", false);
            var usuario = new List<User>{cbf,torcedor};

            var Teams = GeradorDeTeamsCompleto();

            // Quando / Ação
            //var created = Player.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
        }
        
        // Mocks
        public List<Team> GeradorDeTeamsCompleto()
        {
            var flu = new Team("Fluminense");
            AdicionarPlayersFlu(flu);

            var sao = new Team("São Paulo");
            AdicionarPlayersSao(sao);

            var vas = new Team("Vasco");
            AdicionarPlayersVas(vas);

            var cor = new Team("Corintians");
            AdicionarPlayersCor(cor);

            var fla = new Team("Flamengo");
            AdicionarPlayersFla(fla);

            var pal = new Team("Palmeiras");
            AdicionarPlayersPal(pal);

            var bot = new Team("Botafogo");
            AdicionarPlayersBot(bot);

            var san = new Team("Santos");
            AdicionarPlayersSan(san);


            List<Team> teamsList = new List<Team>
            {
                flu,sao,vas,cor,fla,pal,bot,san
            };

            return teamsList;
        }
        private void AdicionarPlayersFlu(Team flu)
        {
            flu.Players.Add(new Player("Santos"));
            flu.Players.Add(new Player("Leo Gomes"));
            flu.Players.Add(new Player("Fabinho"));
            flu.Players.Add(new Player("Pedro Henrique"));
            flu.Players.Add(new Player("Thiago Heleno"));
            flu.Players.Add(new Player("Abner vinicius"));
            flu.Players.Add(new Player("Wellington"));
            flu.Players.Add(new Player("Richard"));
            flu.Players.Add(new Player("Christian"));
            flu.Players.Add(new Player("Leo Cittadin"));
            flu.Players.Add(new Player("Ravanelli"));
            flu.Players.Add(new Player("Bissoli"));
            flu.Players.Add(new Player("Carlos Eduardo"));
            flu.Players.Add(new Player("Nikão"));
            flu.Players.Add(new Player("Renato Kayser"));
            flu.Players.Add(new Player("Geuvanio"));
            flu.Players.Add(new Player("Jandrei"));
            flu.Players.Add(new Player("Kellven"));
            flu.Players.Add(new Player("Aguilar"));
            flu.Players.Add(new Player("João Victor"));
            flu.Players.Add(new Player("Lucho Gonzales"));
            flu.Players.Add(new Player("Alvarado"));
            flu.Players.Add(new Player("Walter"));
        }
        private void AdicionarPlayersSao(Team sao)
        {
            sao.Players.Add(new Player("Jean"));
            sao.Players.Add(new Player("Dudu"));
            sao.Players.Add(new Player("João Victor"));
            sao.Players.Add(new Player("Éder"));
            sao.Players.Add(new Player("Natanael"));
            sao.Players.Add(new Player("Willian Maranhão"));
            sao.Players.Add(new Player("Marlon Freitas"));
            sao.Players.Add(new Player("Arnaldo"));
            sao.Players.Add(new Player("Zé Roberto"));
            sao.Players.Add(new Player("Hyuri"));
            sao.Players.Add(new Player("Matheus Vargas"));
            sao.Players.Add(new Player("Matheuzinho"));
            sao.Players.Add(new Player("Mauricio Kozlinski"));
            sao.Players.Add(new Player("Luan Sales"));
            sao.Players.Add(new Player("Oliveira"));
            sao.Players.Add(new Player("Gilvan"));
            sao.Players.Add(new Player("Everton Felipe"));
            sao.Players.Add(new Player("Wellington Rato"));
            sao.Players.Add(new Player("Junior Brandão"));
        }
        private void AdicionarPlayersVas(Team vas)
        {
            vas.Players.Add(new Player("Éverson"));
            vas.Players.Add(new Player("Guga"));
            vas.Players.Add(new Player("Réver"));
            vas.Players.Add(new Player("Junior Alonso"));
            vas.Players.Add(new Player("Guilherme Arana"));
            vas.Players.Add(new Player("Jair"));
            vas.Players.Add(new Player("Franco"));
            vas.Players.Add(new Player("Nathan"));
            vas.Players.Add(new Player("Savarino"));
            vas.Players.Add(new Player("Eduardo Sasha"));
            vas.Players.Add(new Player("Keno"));
            vas.Players.Add(new Player("Victor"));
            vas.Players.Add(new Player("Rafael"));
            vas.Players.Add(new Player("Mailton"));
            vas.Players.Add(new Player("Mariano"));
            vas.Players.Add(new Player("Igor Rabello"));
            vas.Players.Add(new Player("Bueno"));
            vas.Players.Add(new Player("Gabriel"));
            vas.Players.Add(new Player("Borrero"));
            vas.Players.Add(new Player("Calebe"));
            vas.Players.Add(new Player("Savio"));
            vas.Players.Add(new Player("Marrony"));
            vas.Players.Add(new Player("Marquinhos"));
        }
        private void AdicionarPlayersCor(Team cor)
        {
            cor.Players.Add(new Player("Douglas Friedrich"));
            cor.Players.Add(new Player("Ernando"));
            cor.Players.Add(new Player("Lucas Fonseca"));
            cor.Players.Add(new Player("Juninho"));
            cor.Players.Add(new Player("Juninho Capixaba"));
            cor.Players.Add(new Player("Gregore"));
            cor.Players.Add(new Player("Elias"));
            cor.Players.Add(new Player("Edson"));
            cor.Players.Add(new Player("Ramon"));
            cor.Players.Add(new Player("Fessin"));
            cor.Players.Add(new Player("Clayson"));
            cor.Players.Add(new Player("Mateus Claus"));
            cor.Players.Add(new Player("Wanderson"));
            cor.Players.Add(new Player("Nino Paraiba"));
            cor.Players.Add(new Player("Anderson Martins"));
            cor.Players.Add(new Player("Matheus Bahia"));
            cor.Players.Add(new Player("Ronaldo"));
            cor.Players.Add(new Player("Daniel"));
            cor.Players.Add(new Player("Ramires"));
            cor.Players.Add(new Player("Alesson"));
            cor.Players.Add(new Player("Marco Antonio"));
            cor.Players.Add(new Player("Gilberto"));
            cor.Players.Add(new Player("Saldanha"));
        }
        private void AdicionarPlayersFla(Team fla)
        {
            fla.Players.Add(new Player("Hugo Souza"));
            fla.Players.Add(new Player("Diego Alves"));
            fla.Players.Add(new Player("Mauricio Isla"));
            fla.Players.Add(new Player("Rodrigo Caio"));
            fla.Players.Add(new Player("Gustavo Henrique"));
            fla.Players.Add(new Player("Natan"));
            fla.Players.Add(new Player("Gabriel Noga"));
            fla.Players.Add(new Player("Filipe Luis"));
            fla.Players.Add(new Player("Thiago Maia"));
            fla.Players.Add(new Player("Willian Arão"));
            fla.Players.Add(new Player("Gerson"));
            fla.Players.Add(new Player("Everton Ribeiro"));
            fla.Players.Add(new Player("Ramon"));
            fla.Players.Add(new Player("De Arrascaeta"));
            fla.Players.Add(new Player("Bruno Henrique"));
            fla.Players.Add(new Player("Pedro"));
            fla.Players.Add(new Player("Lincoln"));
            fla.Players.Add(new Player("Vitinho"));
            fla.Players.Add(new Player("Diego"));
            fla.Players.Add(new Player("Gabigol"));
            fla.Players.Add(new Player("Cézar"));
            fla.Players.Add(new Player("Gabriel Batista"));
            fla.Players.Add(new Player("Matheuzinho"));
            fla.Players.Add(new Player("João Lucas"));
            fla.Players.Add(new Player("Thuler"));
            fla.Players.Add(new Player("Léo Pereira"));
            fla.Players.Add(new Player("Renê"));
            fla.Players.Add(new Player("Gomes"));
            fla.Players.Add(new Player("Pepe"));
            fla.Players.Add(new Player("Pedro Rocha"));
            fla.Players.Add(new Player("Michael"));  
        }
        private void AdicionarPlayersPal(Team pal)
        {
            pal.Players.Add(new Player("Diego Cavalieri"));
            pal.Players.Add(new Player("Kevin"));
            pal.Players.Add(new Player("Marcelo Benevenuto"));
            pal.Players.Add(new Player("Kanu"));
            pal.Players.Add(new Player("Victor Luis"));
            pal.Players.Add(new Player("Rafael Forster"));
            pal.Players.Add(new Player("Caio Alexandre"));
            pal.Players.Add(new Player("Honda"));
            pal.Players.Add(new Player("Bruno Nazario"));
            pal.Players.Add(new Player("Rhuan"));
            pal.Players.Add(new Player("Pedro Raul"));
            pal.Players.Add(new Player("Saulo"));
            pal.Players.Add(new Player("Barrandeguy"));
            pal.Players.Add(new Player("David Souza"));
            pal.Players.Add(new Player("Guilherme Santos"));
            pal.Players.Add(new Player("Renteria"));
            pal.Players.Add(new Player("Eder Bessa"));
            pal.Players.Add(new Player("Luiz Otávio"));
            pal.Players.Add(new Player("Cicero"));
            pal.Players.Add(new Player("matheus Babi"));
            pal.Players.Add(new Player("Lecaros"));
            pal.Players.Add(new Player("Warley"));
            pal.Players.Add(new Player("Davi Araujo"));
        }       
        private void AdicionarPlayersBot(Team bot)
        {
            bot.Players.Add(new Player("Cleiton"));
            bot.Players.Add(new Player("Aderlan"));
            bot.Players.Add(new Player("Léo Ortiz"));
            bot.Players.Add(new Player("Ligger"));
            bot.Players.Add(new Player("Wewerson"));
            bot.Players.Add(new Player("Edimar"));
            bot.Players.Add(new Player("Ricardo Ryller"));
            bot.Players.Add(new Player("Uillian Correia"));
            bot.Players.Add(new Player("Raul"));
            bot.Players.Add(new Player("Arthur"));
            bot.Players.Add(new Player("Cuello"));
            bot.Players.Add(new Player("Bruno Tubarão"));
            bot.Players.Add(new Player("Ytalo"));
            bot.Players.Add(new Player("Hurtado"));
            bot.Players.Add(new Player("Claudinho"));
            bot.Players.Add(new Player("Luis Phelipe"));
            bot.Players.Add(new Player("Julio Cesar"));
            bot.Players.Add(new Player("Haydar"));
            bot.Players.Add(new Player("Fabricio Brunno"));
            bot.Players.Add(new Player("Chirgor"));
            bot.Players.Add(new Player("Morato"));
        }                
        private void AdicionarPlayersSan(Team san)
        {
            san.Players.Add(new Player("Fernando Prass"));
            san.Players.Add(new Player("Fabinho"));
            san.Players.Add(new Player("Tiago"));
            san.Players.Add(new Player("Eduardo Brock"));
            san.Players.Add(new Player("Bruno Pacheco"));
            san.Players.Add(new Player("Pedro Naressi"));
            san.Players.Add(new Player("Leandro Carvalho"));
            san.Players.Add(new Player("Charles"));
            san.Players.Add(new Player("Fernando Sobral"));
            san.Players.Add(new Player("Vinicius"));
            san.Players.Add(new Player("Lima"));
            san.Players.Add(new Player("Leo Chu"));
            san.Players.Add(new Player("Kelvyn"));
            san.Players.Add(new Player("Rafael Sobis"));
            san.Players.Add(new Player("Cleber"));
            san.Players.Add(new Player("Diogo Silva"));
            san.Players.Add(new Player("Gabriel Lacerda"));
            san.Players.Add(new Player("Alyson"));
            san.Players.Add(new Player("Marthã"));
            san.Players.Add(new Player("Felipe Baixola"));
            san.Players.Add(new Player("Wescley"));
        }
    }
}
