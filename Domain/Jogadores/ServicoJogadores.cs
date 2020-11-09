using System;
using Domain.Jogadores;

namespace Domain.Jogadores
{
    public class ServicoJogadores
    {
        public Guid Create(string nome)
        {
            var jogador = new Jogador(nome);
            RepositorioJogadores.Add(jogador);
            return jogador.Id;
        }
    }
}
