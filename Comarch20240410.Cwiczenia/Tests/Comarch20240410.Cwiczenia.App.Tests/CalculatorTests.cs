using Comarch20240410.Cwiczenia.App.Services;

namespace Comarch20240410.Cwiczenia.App.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddShouldReturnCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int expected = 4, x = 2, y = 2;

            // Act
            int actual = calculator.Add(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}