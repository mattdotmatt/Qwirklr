using System.Collections.Generic;

namespace Qwirklr.Entities
{
    public class Game
    {
        public Game(int numberOfPlayers)
        {
            Bag = new Bag(108);
            Players = new List<Player>
                {
                    new Player(),
                    new Player(),
                    new Player(),
                };
        }

        public Bag Bag { get; private set; }

        public List<Player> Players { get; private set; }

        public void Start()
        {
            foreach (var player in Players)
            {
                TakeFirstTurn(player);
            }
        }

        private void TakeFirstTurn(Player player)
        {
            player.Tiles = Bag.GetFirstHand();
        }
    }
}