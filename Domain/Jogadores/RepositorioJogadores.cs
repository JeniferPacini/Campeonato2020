using System;
using System.Collections.Generic;

namespace Domain.Jogadores
{
    public class RepositorioJogadores
    {
        private static List<Jogador> _jogadores = new List<Jogador>();
        public static IReadOnlyCollection<Jogador> Jogadores => _jogadores;

        public static void Add(Jogador jogador)
        {
            
            _jogadores.Add(jogador);
        }
    }
}
