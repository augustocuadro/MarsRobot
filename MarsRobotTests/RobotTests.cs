using MarsRobot;
using Xunit;

namespace MarsRobotTests
{
    public class RobotTests
    {
        [Fact]
        public void GivenValidCommands_WhenRobotCanMove_ThenRobotEndsUpInExpectedPosition()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            var robot = new Robot(plateau);
            var commands = "FFRFLFLF";
            var expectedPosition = new Position(1, 4);
            var expectedFacingPosition = CardinalPoint.West;

            // Act
            robot.ProcessCommands(commands);

            // Assert
            Assert.Equal(expectedPosition.PositionX, robot.Position.PositionX);
            Assert.Equal(expectedPosition.PositionY, robot.Position.PositionY);
            Assert.Equal(expectedFacingPosition, robot.FacingPosition);
        }

        [Fact]
        public void GivenValidCommands_WhenRobotCanNotMove_ThenRobotEndsUpInExpectedPosition()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            var robot = new Robot(plateau);
            var commands = "FFFFF";
            var expectedPosition = new Position(1, 5);
            var expectedFacingPosition = CardinalPoint.North;

            // Act
            robot.ProcessCommands(commands);

            // Assert
            Assert.Equal(expectedPosition.PositionX, robot.Position.PositionX);
            Assert.Equal(expectedPosition.PositionY, robot.Position.PositionY);
            Assert.Equal(expectedFacingPosition, robot.FacingPosition);
        }

        [Fact]
        public void GivenValidCommands_WhenRobotCanNotMove_ThenRobotIgnoresCommands()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            var robot = new Robot(plateau);
            var commands = "RRF";
            var expectedPosition = new Position(1, 1);
            var expectedFacingPosition = CardinalPoint.South;

            // Act
            robot.ProcessCommands(commands);

            // Assert
            Assert.Equal(expectedPosition.PositionX, robot.Position.PositionX);
            Assert.Equal(expectedPosition.PositionY, robot.Position.PositionY);
            Assert.Equal(expectedFacingPosition, robot.FacingPosition);
        }

        [Fact]
        public void GivenNonValidCommands_WhenRobotCanMove_ThenRobotIgnoresCommandsAndEndsUpInExpectedPosition()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            var robot = new Robot(plateau);
            var commands = "XXXXX";
            var expectedPosition = new Position(1, 1);
            var expectedFacingPosition = CardinalPoint.North;

            // Act
            robot.ProcessCommands(commands);

            // Assert
            Assert.Equal(expectedPosition.PositionX, robot.Position.PositionX);
            Assert.Equal(expectedPosition.PositionY, robot.Position.PositionY);
            Assert.Equal(expectedFacingPosition, robot.FacingPosition);
        }
    }
}