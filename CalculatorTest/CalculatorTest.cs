using CsUnitTestWelcomeApp;
using Xunit;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void CalculartorSumTest()
        {
            // Init - Arrange
            Calculator calculator = new Calculator();

            // Action
            int result = calculator.Sum(20, 30);

            // Assert
            Assert.Equal(20 + 30, result);
        }

        [Fact]
        public void CalculartorMultTest()
        {
            // Init
            Calculator calculator = new Calculator();

            // Action
            int result = calculator.Mult(20, 30);

            // Assert
            Assert.Equal(20 * 30, result);
        }

        [Fact]
        public void IntArrayTest()
        {
            var array = new IntArray();

            Assert.All(array.Array, (int item) => Assert.False(item < 5));
        }

        [Fact]
        public void IntArrayAddRandomTest()
        {
            var array = new IntArray();
            int oldSize = array.Array.Count;

            array.AddRandom();

            Assert.Equal(oldSize + 1, array.Array.Count);
        }
    }
}
