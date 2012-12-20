using System.Linq;
using System.Text;
using NUnit.Framework;
using Qwirklr.Entities;
using Qwirklr.Exceptions;

namespace Qwirklr.Tests
{
    [TestFixture]
    public class BagTests
    {
        [Test]
        public void GettingTheFirstSelectionFromTheBagShouldTakeSixTilesFromTheBag()
        {
            // Arrange

            // Act
            var sut = new Bag(108);
            var result = sut.GetFirstHand();

            // Assert
            Assert.That(result.Count, Is.EqualTo(6), "First hand should have six tiles in");
            Assert.That(sut.NumberOfRemainingTiles, Is.EqualTo(102));

        }

        [TestCase(108,3,105)]
        [TestCase(108, 1, 107)]
        [TestCase(108, 6, 102)]
        public void GettingThreeTilesFromTheBagShouldTakeThreeTilesFromTheBag(int startingSize,int numberOfTilesToTake,int remainingTilesInBag)
        {
            // Arrange

            // Act
            var sut = new Bag(startingSize);
            var result = sut.GetTiles(numberOfTilesToTake);

            // Assert
            Assert.That(result.Count, Is.EqualTo(numberOfTilesToTake), "Should be able to specify a number of tiles to take");
            Assert.That(sut.NumberOfRemainingTiles, Is.EqualTo(remainingTilesInBag));

        }

        [Test]
        public void GettingMoreThanTheRemainingTilesFromTheBagShouldReturnOnlyTheRemaining()
        {
            // Arrange

            // Act
            var sut = new Bag(3);
            var result = sut.GetTiles(4);

            // Assert
            Assert.That(result.Count, Is.EqualTo(3), "Should be able to specify a number of tiles to take");
            Assert.That(sut.NumberOfRemainingTiles, Is.EqualTo(0));

        }

        [Test]
        public void GettingMoreThanSixTilesFromTheBagShouldThrowAnException()
        {
            // Arrange

            // Act
            var sut = new Bag(10);

            // Assert
            Assert.Throws<BagException>(() => sut.GetTiles(7), "You cannot take more than 6 tiles from the bag");
        }

    }
}


