using System;
using System.Collections.Generic;
using System.Linq;
using Qwirklr.Exceptions;

namespace Qwirklr.Entities
{
    public class Bag
    {
        private List<Tile> _tiles;

        public Bag(int initialBagSize)
        {
            InitializeBag(initialBagSize);
        }

        private void InitializeBag(int initialBagSize)
        {
            _tiles = new List<Tile>();
            foreach (var tile in Enumerable.Range(1, initialBagSize))
            {
                _tiles.Add(new Tile());
            }
        }

        public List<Tile> GetFirstHand()
        {
            return GetTiles(6);
        }

        public Int32 NumberOfRemainingTiles
        {
            get { return _tiles.Count; }
        }

        public List<Tile> GetTiles(int numberOfTilesToTake)
        {
            if (numberOfTilesToTake > 6) throw new BagException("You cannot take more than 6 tiles from the bag");
            return TakeTilesFromBag(numberOfTilesToTake);
        }

        private List<Tile> TakeTilesFromBag(int numberOfTilesToTake)
        {
            numberOfTilesToTake = VerifyNumberOfTilesToTake(numberOfTilesToTake);
            var selectedTiles = new Tile[numberOfTilesToTake];
            _tiles.CopyTo(0, selectedTiles, 0, numberOfTilesToTake);
            _tiles.RemoveRange(0, numberOfTilesToTake);
            return selectedTiles.ToList();
        }

        private int VerifyNumberOfTilesToTake(int numberOfTilesToTake)
        {
            if (numberOfTilesToTake > NumberOfRemainingTiles) numberOfTilesToTake = NumberOfRemainingTiles;
            return numberOfTilesToTake;
        }
    }
}