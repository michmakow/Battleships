using Battleships.Models;
using Battleships.Utility;

using static Battleships.Utility.Enums;

namespace Battleships.tests.Models
{
    public class ShipTests
    {
        private Ship CreateBattleship() => new(ShipEnum.Battleship);

        private Ship CreateDestroyer() => new(ShipEnum.Destroyer);

        [Fact]
        public void ShouldCreateBattleship()
        {
            // Arrange
            var ship = CreateBattleship();
            // Act
            // Nothing to act
            // Assert
            ship.Name.Should().Be(ShipEnum.Battleship);
            ship.Coordinates.Should().BeEmpty();
            ship.Lenght.Should().Be(Consts.BattleshipLenght);
        }

        [Fact]
        public void ShouldCreateDestroyer()
        {
            // Arrange
            var ship = CreateDestroyer();
            // Act
            // Nothing to act
            // Assert
            ship.Name.Should().Be(ShipEnum.Destroyer);
            ship.Coordinates.Should().BeEmpty();
            ship.Lenght.Should().Be(Consts.DestroyerLenght);
        }
    }
}