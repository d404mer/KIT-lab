using PR3_1_PITPM;

namespace VolumeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateVolume_ValidInput_ReturnsCorrectVolume()
        {
            // Arrange
            var cylinder = new Cylinder();
            double radius = 3;
            double height = 5;
            double expectedVolume = Math.PI * Math.Pow(radius, 2) * height;

            // Act
            double actualVolume = cylinder.CalculateVolume(radius, height);

            // Assert
            Assert.Equal(expectedVolume, actualVolume, precision: 5);
        }

        [Fact]
        public void CalculateVolume_NegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            var cylinder = new Cylinder();
            double radius = -1;
            double height = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => cylinder.CalculateVolume(radius, height));
        }

        [Fact]
        public void CalculateVolume_NegativeHeight_ThrowsArgumentException()
        {
            // Arrange
            var cylinder = new Cylinder();
            double radius = 3;
            double height = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => cylinder.CalculateVolume(radius, height));
        }
    }
}