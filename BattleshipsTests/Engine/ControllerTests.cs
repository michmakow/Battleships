using Battleships.Engine;
using Battleships.Models;

namespace BattleshipsTests.Engine
{
    public class ControllerTests
    {
        private MockRepository mockRepository;

        private Mock<Board> mockBoard;

        [Fact]
        public void HandleInput_LetterQProvided_ShouldIsRunningBeFalsy()
        {
            // Arrange
            mockRepository = new MockRepository(MockBehavior.Strict);
            mockBoard = mockRepository.Create<Board>();
            var output = new StringWriter();
            Console.SetOut(output);

            bool isRunning = true;

            // Act
            var input = new StringReader("Q");
            Console.SetIn(input);
            Controller.HandleInput(ref isRunning, mockBoard.Object);

            // Assert
            output.ToString().Should().NotBeEmpty();
            isRunning.Should().BeFalse();
        }

        [Theory]
        [InlineData("c123")]
        [InlineData("c11")]
        [InlineData("c")]
        [InlineData(" 1")]
        [InlineData("-1")]
        [InlineData("$#")]
        [InlineData("-1%")]
        [InlineData("//")]
        [InlineData("K5")]
        public void HandleInput_ManyInputsProvidedToTestRegex_AllShouldReturnWrongInputString(string input)
        {
            // Arrange
            mockRepository = new MockRepository(MockBehavior.Strict);
            mockBoard = mockRepository.Create<Board>();
            var output = new StringWriter();
            Console.SetOut(output);

            bool isRunning = true;

            // Act
            Console.SetIn(new StringReader(input));
            Controller.HandleInput(ref isRunning, mockBoard.Object);

            // Assert
            output.ToString().Should().Be("Enter coordinates: \r\nTo much RUM sailor? Stop mumbling\r\n");
            isRunning.Should().BeTrue();
        }

        [Fact]
        public void HandleInput_HitSamePlaceTwice_ShouldReturnHit()
        {
            // Arrange
            mockRepository = new MockRepository(MockBehavior.Strict);
            mockBoard = mockRepository.Create<Board>();
            var output = new StringWriter();
            Console.SetOut(output);

            bool isRunning = true;

            // Act
            var coordinates = mockBoard.Object.Ships.First().Coordinates.First();
            Console.SetIn(new StringReader(coordinates));
            Controller.HandleInput(ref isRunning, mockBoard.Object);

            // Assert
            output.ToString().Should().Be($"Enter coordinates: \r\nCoordinates: {coordinates}! Roger!\r\nFiring!!!!\r\nNice shoot!!! You hit Battleship!\r\n");
            isRunning.Should().BeTrue();
        }
    }
}