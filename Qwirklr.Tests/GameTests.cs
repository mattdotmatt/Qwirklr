using NUnit.Framework;
using Qwirklr.Entities;

namespace Qwirklr.Tests
{
    [TestFixture]
    public class GameTests
    {
         [Test]
         public void AtTheCreationOfTheGameTheBagShouldHave108TilesIn()
         {
             // Arrange

             // Act
             var sut = new Game(0);
             var result = sut.Bag;

             // Assert
             Assert.That(result.NumberOfRemainingTiles,Is.EqualTo(108),"Should have 108 tiles at the game creation.");

         }

         [Test]
         public void AtTheCreationOfTheGameThePlayersShouldHaveNoTiles()
         {
             // Arrange

             // Act
             var sut = new Game(3);
             var result = sut.Players;

             // Assert
             Assert.That(result.Count,Is.EqualTo(3),"Game should have the correct number of players");
             Assert.That(result[0].Tiles.Count, Is.EqualTo(0), "Each player should have 0 tiles at the game creation");
             Assert.That(result[1].Tiles.Count, Is.EqualTo(0), "Each player should have 0 tiles at the game creation");
             Assert.That(result[2].Tiles.Count, Is.EqualTo(0), "Each player should have 0 tiles at the game creation");

         }

        [Test]
        public void AtTheStartOfTheGameEachPlayerShouldGetSixTiles()
        {
            // Arrange
            var sut = new Game(3);

            // Act
            sut.Start();
            var result = sut.Players;

            // Assert
            Assert.That(result[0].Tiles.Count,Is.EqualTo(6), "Each player should have 6 tiles at the game start");
            Assert.That(result[1].Tiles.Count, Is.EqualTo(6), "Each player should have 6 tiles at the game start");
            Assert.That(result[2].Tiles.Count, Is.EqualTo(6), "Each player should have 6 tiles at the game start");

        }

        [Test]
        public void APlayerShouldOnlyBeAbleToPlaceTilesWhenItIsTheirTurn()
        {
            // Arrange

            // Act
            var sut = new Game(2);
            sut.Start();
            //sut.TakeTurn(Player,)

            // Assert


        }

        [Test]
        public void WhenAPlayerPlacesThreeTilesTheirTilesShouldDecreaseByThree()
        {
            // Arrange

            // Act
            var sut = new Game(1);
            sut.Start();
            // Assert


        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(6)]
        public void WhenAPlayerTakesThereTurnTheirTilesShouldBeToppedUpToSix(int playersTileCount)
        {
            // Arrange

            // Act
            var sut = new Game(3);
            sut.Start();


            // Assert


        }
    }
}