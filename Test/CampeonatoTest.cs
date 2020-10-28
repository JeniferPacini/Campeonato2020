using System;
using Xunit;
using Domain;
using System.Collections.Generic;

namespace Test
{
    public class CampeonatoTest
    {
        [Fact]
        public void Deve_retornar_usuario()
        {
            // Dado / Setup
            //var campeonato = new Campeonato();
            var cbf = new Usuario("Jenifer Pacini", true);
            var torcedor = new Usuario("Afonso Padilha", false);
            var usuario = new List<Usuario>{cbf,torcedor};

            var times = GeradorDeTimesCompleto();

            // Quando / Ação
            //var created = jogador.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
        }
        
        // Mocks
        public List<Time> GeradorDeTimesCompleto()
        {
            var flu = new Time("Fluminense");
            AdicionarJogadoresFlu(flu);

            var sao = new Time("São Paulo");
            AdicionarJogadoresSao(sao);

            var vas = new Time("Vasco");
            AdicionarJogadoresVas(vas);

            var cor = new Time("Corintians");
            AdicionarJogadoresCor(cor);

            var fla = new Time("Flamengo");
            AdicionarJogadoresFla(fla);

            var pal = new Time("Palmeiras");
            AdicionarJogadoresPal(pal);

            var bot = new Time("Botafogo");
            AdicionarJogadoresBot(bot);

            var san = new Time("Santos");
            AdicionarJogadoresSan(san);


            List<Time> listaTimes = new List<Time>
            {
                flu,sao,vas,cor,fla,pal,bot,san
            };

            return listaTimes;
        }
        private void AdicionarJogadoresFlu(Time flu)
        {
            flu.Jogadores.Add(new Jogador("Santos"));
            flu.Jogadores.Add(new Jogador("Leo Gomes"));
            flu.Jogadores.Add(new Jogador("Fabinho"));
            flu.Jogadores.Add(new Jogador("Pedro Henrique"));
            flu.Jogadores.Add(new Jogador("Thiago Heleno"));
            flu.Jogadores.Add(new Jogador("Abner vinicius"));
            flu.Jogadores.Add(new Jogador("Wellington"));
            flu.Jogadores.Add(new Jogador("Richard"));
            flu.Jogadores.Add(new Jogador("Christian"));
            flu.Jogadores.Add(new Jogador("Leo Cittadin"));
            flu.Jogadores.Add(new Jogador("Ravanelli"));
            flu.Jogadores.Add(new Jogador("Bissoli"));
            flu.Jogadores.Add(new Jogador("Carlos Eduardo"));
            flu.Jogadores.Add(new Jogador("Nikão"));
            flu.Jogadores.Add(new Jogador("Renato Kayser"));
            flu.Jogadores.Add(new Jogador("Geuvanio"));
            flu.Jogadores.Add(new Jogador("Jandrei"));
            flu.Jogadores.Add(new Jogador("Kellven"));
            flu.Jogadores.Add(new Jogador("Aguilar"));
            flu.Jogadores.Add(new Jogador("João Victor"));
            flu.Jogadores.Add(new Jogador("Lucho Gonzales"));
            flu.Jogadores.Add(new Jogador("Alvarado"));
            flu.Jogadores.Add(new Jogador("Walter"));
        }
        private void AdicionarJogadoresSao(Time sao)
        {
            sao.Jogadores.Add(new Jogador("Jean"));
            sao.Jogadores.Add(new Jogador("Dudu"));
            sao.Jogadores.Add(new Jogador("João Victor"));
            sao.Jogadores.Add(new Jogador("Éder"));
            sao.Jogadores.Add(new Jogador("Natanael"));
            sao.Jogadores.Add(new Jogador("Willian Maranhão"));
            sao.Jogadores.Add(new Jogador("Marlon Freitas"));
            sao.Jogadores.Add(new Jogador("Arnaldo"));
            sao.Jogadores.Add(new Jogador("Zé Roberto"));
            sao.Jogadores.Add(new Jogador("Hyuri"));
            sao.Jogadores.Add(new Jogador("Matheus Vargas"));
            sao.Jogadores.Add(new Jogador("Matheuzinho"));
            sao.Jogadores.Add(new Jogador("Mauricio Kozlinski"));
            sao.Jogadores.Add(new Jogador("Luan Sales"));
            sao.Jogadores.Add(new Jogador("Oliveira"));
            sao.Jogadores.Add(new Jogador("Gilvan"));
            sao.Jogadores.Add(new Jogador("Everton Felipe"));
            sao.Jogadores.Add(new Jogador("Wellington Rato"));
            sao.Jogadores.Add(new Jogador("Junior Brandão"));
        }
        private void AdicionarJogadoresVas(Time vas)
        {
            vas.Jogadores.Add(new Jogador("Éverson"));
            vas.Jogadores.Add(new Jogador("Guga"));
            vas.Jogadores.Add(new Jogador("Réver"));
            vas.Jogadores.Add(new Jogador("Junior Alonso"));
            vas.Jogadores.Add(new Jogador("Guilherme Arana"));
            vas.Jogadores.Add(new Jogador("Jair"));
            vas.Jogadores.Add(new Jogador("Franco"));
            vas.Jogadores.Add(new Jogador("Nathan"));
            vas.Jogadores.Add(new Jogador("Savarino"));
            vas.Jogadores.Add(new Jogador("Eduardo Sasha"));
            vas.Jogadores.Add(new Jogador("Keno"));
            vas.Jogadores.Add(new Jogador("Victor"));
            vas.Jogadores.Add(new Jogador("Rafael"));
            vas.Jogadores.Add(new Jogador("Mailton"));
            vas.Jogadores.Add(new Jogador("Mariano"));
            vas.Jogadores.Add(new Jogador("Igor Rabello"));
            vas.Jogadores.Add(new Jogador("Bueno"));
            vas.Jogadores.Add(new Jogador("Gabriel"));
            vas.Jogadores.Add(new Jogador("Borrero"));
            vas.Jogadores.Add(new Jogador("Calebe"));
            vas.Jogadores.Add(new Jogador("Savio"));
            vas.Jogadores.Add(new Jogador("Marrony"));
            vas.Jogadores.Add(new Jogador("Marquinhos"));
        }
        private void AdicionarJogadoresCor(Time cor)
        {
            cor.Jogadores.Add(new Jogador("Douglas Friedrich"));
            cor.Jogadores.Add(new Jogador("Ernando"));
            cor.Jogadores.Add(new Jogador("Lucas Fonseca"));
            cor.Jogadores.Add(new Jogador("Juninho"));
            cor.Jogadores.Add(new Jogador("Juninho Capixaba"));
            cor.Jogadores.Add(new Jogador("Gregore"));
            cor.Jogadores.Add(new Jogador("Elias"));
            cor.Jogadores.Add(new Jogador("Edson"));
            cor.Jogadores.Add(new Jogador("Ramon"));
            cor.Jogadores.Add(new Jogador("Fessin"));
            cor.Jogadores.Add(new Jogador("Clayson"));
            cor.Jogadores.Add(new Jogador("Mateus Claus"));
            cor.Jogadores.Add(new Jogador("Wanderson"));
            cor.Jogadores.Add(new Jogador("Nino Paraiba"));
            cor.Jogadores.Add(new Jogador("Anderson Martins"));
            cor.Jogadores.Add(new Jogador("Matheus Bahia"));
            cor.Jogadores.Add(new Jogador("Ronaldo"));
            cor.Jogadores.Add(new Jogador("Daniel"));
            cor.Jogadores.Add(new Jogador("Ramires"));
            cor.Jogadores.Add(new Jogador("Alesson"));
            cor.Jogadores.Add(new Jogador("Marco Antonio"));
            cor.Jogadores.Add(new Jogador("Gilberto"));
            cor.Jogadores.Add(new Jogador("Saldanha"));
        }
        private void AdicionarJogadoresFla(Time fla)
        {
            fla.Jogadores.Add(new Jogador("Hugo Souza"));
            fla.Jogadores.Add(new Jogador("Diego Alves"));
            fla.Jogadores.Add(new Jogador("Mauricio Isla"));
            fla.Jogadores.Add(new Jogador("Rodrigo Caio"));
            fla.Jogadores.Add(new Jogador("Gustavo Henrique"));
            fla.Jogadores.Add(new Jogador("Natan"));
            fla.Jogadores.Add(new Jogador("Gabriel Noga"));
            fla.Jogadores.Add(new Jogador("Filipe Luis"));
            fla.Jogadores.Add(new Jogador("Thiago Maia"));
            fla.Jogadores.Add(new Jogador("Willian Arão"));
            fla.Jogadores.Add(new Jogador("Gerson"));
            fla.Jogadores.Add(new Jogador("Everton Ribeiro"));
            fla.Jogadores.Add(new Jogador("Ramon"));
            fla.Jogadores.Add(new Jogador("De Arrascaeta"));
            fla.Jogadores.Add(new Jogador("Bruno Henrique"));
            fla.Jogadores.Add(new Jogador("Pedro"));
            fla.Jogadores.Add(new Jogador("Lincoln"));
            fla.Jogadores.Add(new Jogador("Vitinho"));
            fla.Jogadores.Add(new Jogador("Diego"));
            fla.Jogadores.Add(new Jogador("Gabigol"));
            fla.Jogadores.Add(new Jogador("Cézar"));
            fla.Jogadores.Add(new Jogador("Gabriel Batista"));
            fla.Jogadores.Add(new Jogador("Matheuzinho"));
            fla.Jogadores.Add(new Jogador("João Lucas"));
            fla.Jogadores.Add(new Jogador("Thuler"));
            fla.Jogadores.Add(new Jogador("Léo Pereira"));
            fla.Jogadores.Add(new Jogador("Renê"));
            fla.Jogadores.Add(new Jogador("Gomes"));
            fla.Jogadores.Add(new Jogador("Pepe"));
            fla.Jogadores.Add(new Jogador("Pedro Rocha"));
            fla.Jogadores.Add(new Jogador("Michael"));  
        }
        private void AdicionarJogadoresPal(Time pal)
        {
            pal.Jogadores.Add(new Jogador("Diego Cavalieri"));
            pal.Jogadores.Add(new Jogador("Kevin"));
            pal.Jogadores.Add(new Jogador("Marcelo Benevenuto"));
            pal.Jogadores.Add(new Jogador("Kanu"));
            pal.Jogadores.Add(new Jogador("Victor Luis"));
            pal.Jogadores.Add(new Jogador("Rafael Forster"));
            pal.Jogadores.Add(new Jogador("Caio Alexandre"));
            pal.Jogadores.Add(new Jogador("Honda"));
            pal.Jogadores.Add(new Jogador("Bruno Nazario"));
            pal.Jogadores.Add(new Jogador("Rhuan"));
            pal.Jogadores.Add(new Jogador("Pedro Raul"));
            pal.Jogadores.Add(new Jogador("Saulo"));
            pal.Jogadores.Add(new Jogador("Barrandeguy"));
            pal.Jogadores.Add(new Jogador("David Souza"));
            pal.Jogadores.Add(new Jogador("Guilherme Santos"));
            pal.Jogadores.Add(new Jogador("Renteria"));
            pal.Jogadores.Add(new Jogador("Eder Bessa"));
            pal.Jogadores.Add(new Jogador("Luiz Otávio"));
            pal.Jogadores.Add(new Jogador("Cicero"));
            pal.Jogadores.Add(new Jogador("matheus Babi"));
            pal.Jogadores.Add(new Jogador("Lecaros"));
            pal.Jogadores.Add(new Jogador("Warley"));
            pal.Jogadores.Add(new Jogador("Davi Araujo"));
        }       
        private void AdicionarJogadoresBot(Time bot)
        {
            bot.Jogadores.Add(new Jogador("Cleiton"));
            bot.Jogadores.Add(new Jogador("Aderlan"));
            bot.Jogadores.Add(new Jogador("Léo Ortiz"));
            bot.Jogadores.Add(new Jogador("Ligger"));
            bot.Jogadores.Add(new Jogador("Wewerson"));
            bot.Jogadores.Add(new Jogador("Edimar"));
            bot.Jogadores.Add(new Jogador("Ricardo Ryller"));
            bot.Jogadores.Add(new Jogador("Uillian Correia"));
            bot.Jogadores.Add(new Jogador("Raul"));
            bot.Jogadores.Add(new Jogador("Arthur"));
            bot.Jogadores.Add(new Jogador("Cuello"));
            bot.Jogadores.Add(new Jogador("Bruno Tubarão"));
            bot.Jogadores.Add(new Jogador("Ytalo"));
            bot.Jogadores.Add(new Jogador("Hurtado"));
            bot.Jogadores.Add(new Jogador("Claudinho"));
            bot.Jogadores.Add(new Jogador("Luis Phelipe"));
            bot.Jogadores.Add(new Jogador("Julio Cesar"));
            bot.Jogadores.Add(new Jogador("Haydar"));
            bot.Jogadores.Add(new Jogador("Fabricio Brunno"));
            bot.Jogadores.Add(new Jogador("Chirgor"));
            bot.Jogadores.Add(new Jogador("Morato"));
        }                
        private void AdicionarJogadoresSan(Time san)
        {
            san.Jogadores.Add(new Jogador("Fernando Prass"));
            san.Jogadores.Add(new Jogador("Fabinho"));
            san.Jogadores.Add(new Jogador("Tiago"));
            san.Jogadores.Add(new Jogador("Eduardo Brock"));
            san.Jogadores.Add(new Jogador("Bruno Pacheco"));
            san.Jogadores.Add(new Jogador("Pedro Naressi"));
            san.Jogadores.Add(new Jogador("Leandro Carvalho"));
            san.Jogadores.Add(new Jogador("Charles"));
            san.Jogadores.Add(new Jogador("Fernando Sobral"));
            san.Jogadores.Add(new Jogador("Vinicius"));
            san.Jogadores.Add(new Jogador("Lima"));
            san.Jogadores.Add(new Jogador("Leo Chu"));
            san.Jogadores.Add(new Jogador("Kelvyn"));
            san.Jogadores.Add(new Jogador("Rafael Sobis"));
            san.Jogadores.Add(new Jogador("Cleber"));
            san.Jogadores.Add(new Jogador("Diogo Silva"));
            san.Jogadores.Add(new Jogador("Gabriel Lacerda"));
            san.Jogadores.Add(new Jogador("Alyson"));
            san.Jogadores.Add(new Jogador("Marthã"));
            san.Jogadores.Add(new Jogador("Felipe Baixola"));
            san.Jogadores.Add(new Jogador("Wescley"));
        }
    }
}
