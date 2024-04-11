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
            int expected = 4, a = 2, b = 2;

            // Act
            int actual = calculator.Add(y: b, x: a);
            int actual2 = calculator.Add(x: 4);


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}