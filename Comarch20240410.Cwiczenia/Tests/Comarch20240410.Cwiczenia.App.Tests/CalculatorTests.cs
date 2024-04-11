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

        [Test]
        public void SortShouldReturnSortedArray() 
        {
            // Arrange
            Calculator calculator = new Calculator();
            int[] input = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
            int[] expected = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // Act
            int[] actual = calculator.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}