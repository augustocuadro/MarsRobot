using MarsRobot;
using Xunit;

namespace MarsRobotTests
{
    public class HelperTests
    {
        [Fact]
        public void GivenValidSize_WhenSizeInputIsDecomposed_ThenCorrectNumberOfRowsColsAreObtained()
        {
            // Assert
            var size = "5x5";
            var expectedRows = 5;
            var expectedCols = 5;

            // Act
            var (rows, cols) = Helper.DecomposePlateauInputSize(size);

            // Assert
            Assert.Equal(expectedRows, rows);
            Assert.Equal(expectedCols, cols);
        }
    }
}
