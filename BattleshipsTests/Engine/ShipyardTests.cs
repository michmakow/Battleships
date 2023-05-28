using Battleships.Models;
using static Battleships.Utility.Enums;

namespace BattleshipsTests.Engine
{
    public class ShipyardTests
    {
        private MockRepository mockRepository;

        private Mock<Board> mockBoard;

        [Fact]
        public void ShouldCreateShipyeardAndFillBoardWithShips()
        {
            // Arrange
            mockRepository = new MockRepository(MockBehavior.Strict);
            mockBoard = mockRepository.Create<Board>();
            // Act
            // Nothing to act
            // Assert
            mockBoard.Object.Should().NotBeNull();
            mockBoard.Object.Ships.Should().HaveCount(4);
            mockBoard.Object.Ships.Should().Contain(x => x.Name == ShipEnum.Battleship);
            mockBoard.Object.Ships.Should().Contain(x => x.Name == ShipEnum.Destroyer);

            var firstShip = mockBoard.Object.Ships[0];
            var secondShip = mockBoard.Object.Ships[1];
            var thirdShip = mockBoard.Object.Ships[2];
            var fourthShip = mockBoard.Object.Ships[3];

            firstShip.Coordinates.Should().NotIntersectWith(secondShip.Coordinates);
            firstShip.Coordinates.Should().NotIntersectWith(thirdShip.Coordinates);
            firstShip.Coordinates.Should().NotIntersectWith(fourthShip.Coordinates);
            secondShip.Coordinates.Should().NotIntersectWith(thirdShip.Coordinates);
            secondShip.Coordinates.Should().NotIntersectWith(fourthShip.Coordinates);
            thirdShip.Coordinates.Should().NotIntersectWith(fourthShip.Coordinates);

            foreach (var ship in mockBoard.Object.Ships)
            {
                ship.Coordinates.Should().OnlyHaveUniqueItems();
            }
        }
    }
}