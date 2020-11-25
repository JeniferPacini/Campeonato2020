using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Players
{
    public class PlayersRepository
    {
        private static List<Player> _players = new List<Player>();
        public static IReadOnlyCollection<Player> Players => _players;

        public static void Add(Player player)
        {
            _players.Add(player);
        }

        public static void Delete(Guid id)
        {
            var playerRemove = _players.FirstOrDefault(x => x.Id == id);
            _players.Remove(playerRemove);
        }
    }
}
