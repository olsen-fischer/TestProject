namespace TestProject1
{
    public class CalculatorTestProject
    {

            [Fact]
            public void Add_ReturnsCorrectSum()
            {
                // Arrange
                var calculator = new Calculator();
                double a = 5;
                double b = 3;

                // Act
                var result = calculator.Add(a, b);

                // Assert
                Assert.Equal(8, result);
            }

            [Fact]
            public void Subtract_ReturnsCorrectDifference()
            {
                // Arrange
                var calculator = new Calculator();
                double a = 5;
                double b = 3;

                // Act
                var result = calculator.Subtract(a, b);

                // Assert
                Assert.Equal(2, result);
            }

            [Fact]
            public void Multiply_ReturnsCorrectProduct()
            {
                // Arrange
                var calculator = new Calculator();
                double a = 5;
                double b = 3;

                // Act
                var result = calculator.Multiply(a, b);

                // Assert
                Assert.Equal(15, result);
            }

            [Fact]
            public void Divide_ReturnsCorrectQuotient()
            {
                // Arrange
                var calculator = new Calculator();
                double a = 6;
                double b = 3;

                // Act
                var result = calculator.Divide(a, b);

                // Assert
                Assert.Equal(2, result);
            }

            [Fact]
            public void Divide_ByZeroThrowsException()
            {
                // Arrange
                var calculator = new Calculator();
                double a = 6;
                double b = 0;

                // Act & Assert
                Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
            }
        }
    }
