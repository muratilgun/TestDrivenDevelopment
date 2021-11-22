using FluentAssertions;
using Xunit;

namespace StringCalculator.Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("",0)]
        [InlineData("1",1)]
        [InlineData("1,2",3)]
        public void Add_AddsUpToTwoNumber_WhenStringIsValid(string calculation, int expected)
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Add(calculation);
            // Assert
            result.Should().Be(expected);
        }
    }
}