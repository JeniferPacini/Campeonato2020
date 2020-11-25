using System;

namespace Domain.Players
{
    public class PlayersService
    {
        public CreatedPlayerDto Create(string name)
        {
            var player = new Player(name);
            var validatePlayer = player.Validate();

            if(validatePlayer.isValid)
            {
                PlayersRepository.Add(player);
                return new CreatedPlayerDto(player.Id);
            }

            return new CreatedPlayerDto(validatePlayer.errors);
        }

        public CreatedPlayerDto Update(Guid id, string name)
        {
            var player = new Player(name);
            var validatePlayer = player.Validate();

            if(validatePlayer.isValid)
            {
                PlayersRepository.Add(player);
                PlayersRepository.Delete(id);
                return new CreatedPlayerDto(player.Id);
            }

            return new CreatedPlayerDto(validatePlayer.errors);
        }
    }
}
