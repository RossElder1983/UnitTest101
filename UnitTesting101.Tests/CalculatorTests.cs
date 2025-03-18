namespace UnitTesting101.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            // Instantiate the Calculator before each test.
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 2, b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert            
            Assert.That(5, Is.EqualTo(result), "Adding 2 and 3 should return 5");
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 5, b = 3;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(2, Is.EqualTo(result), "Subtracting 3 from 5 should return 2");
        }

        // Additional tests can be added to cover more edge cases and scenarios.
    }
}