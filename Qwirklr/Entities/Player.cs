using System.Collections.Generic;

namespace Qwirklr.Entities
{
    public class Player
    {
        public Player()
        {
            Tiles = new List<Tile>();
        }

        public List<Tile> Tiles { get; set; }

        public void TakeTurn()
        {
            throw new System.NotImplementedException();
        }
    }
}