using Battleships.Models;

namespace BattleshipsTests.Models
{
    public class BoardTests
    {
        private Board CreateBoard() => new();

        [Fact]
        public void ShowBoard_ConsoleShouldLogEntireBoard()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);
            var board = CreateBoard();

            // Act
            board.ShowBoard();

            // Assert
            output.ToString().Should().NotBeEmpty();
        }

        [Fact]
        public void CheckIfThereIsMoreShipParts_ShipHasFullPars_IsRunningShouldStayTrueAndShouldLogShipHit()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);
            var board = CreateBoard();
            var isRunning = true;
            var ship = board.Ships.First();

            // Act
            board.CheckIfThereIsMoreShipParts(
                ref isRunning,
                ship);

            // Assert
            output.ToString().Should().NotBeEmpty();
            isRunning.Should().BeTrue();
        }

        [Fact]
        public void CheckIfThereIsMoreShipParts_ShipHasNoParts_IsRunningShouldBeTruthyAndShipShouldBeDeletedFromCollection()
        {
            // Arrange
            var board = CreateBoard();
            var isRunning = true;

            // Act
            var ship = board.Ships.First();
            ship.Coordinates.Clear();
            board.CheckIfThereIsMoreShipParts(
                ref isRunning,
                ship);

            // Assert
            isRunning.Should().BeTrue();
            board.Ships.Should().NotContain(ship);
        }

        [Fact]
        public void CheckIfThereIsMoreShipParts_ShipHasNoParts_IsRunningShouldChangeToFalsyAndAllShipsShouldBeDeletedFromCollection()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);
            var board = CreateBoard();
            var isRunning = true;

            // Act
            var ship = board.Ships.First();
            board.Ships.Clear();
            ship.Coordinates.Clear();

            board.CheckIfThereIsMoreShipParts(
                ref isRunning,
                ship);

            // Assert
            output.ToString().Should().NotBeEmpty();
            isRunning.Should().BeFalse();
            board.Ships.Should().NotContain(ship);
        }
    }
}