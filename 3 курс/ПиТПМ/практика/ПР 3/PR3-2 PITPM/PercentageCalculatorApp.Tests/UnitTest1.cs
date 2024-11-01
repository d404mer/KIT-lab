using PR3_2_PITPM;

namespace PercentageCalculatorApp.Tests
{
    public class PercentageCalculatorTests
    {
        [Fact]
        public void CalculatePercentage_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new PercentageCalculator();
            double percentage = 20;
            double number = 50;
            double expected = 10; // 20% от 50 равно 10

            // Act
            double actual = calculator.CalculatePercentage(percentage, number);

            // Assert
            Assert.Equal(expected, actual, precision: 2);
        }

        [Fact]
        public void CalculatePercentage_ZeroPercentage_ReturnsZero()
        {
            // Arrange
            var calculator = new PercentageCalculator();
            double percentage = 0;
            double number = 50;
            double expected = 0;

            // Act
            double actual = calculator.CalculatePercentage(percentage, number);

            // Assert
            Assert.Equal(expected, actual, precision: 2);
        }

        [Fact]
        public void CalculatePercentage_ZeroNumber_ReturnsZero()
        {
            // Arrange
            var calculator = new PercentageCalculator();
            double percentage = 20;
            double number = 0;
            double expected = 0;

            // Act
            double actual = calculator.CalculatePercentage(percentage, number);

            // Assert
            Assert.Equal(expected, actual, precision: 2);
        }
    }
}