using System;
using Xunit;
using fizzbuzz.services;
using FluentAssertions;

namespace fizzbuzz.unittests
{
    public class FizzBuzzServiceTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(30)]
        public void Print_WhenTheNumberDivisableByThree_ShouldPrintFizz(int num)
        {
            // Arrange
            var service = new FizzBuzzService();

            // Act
            var result = service.Print(num);

            // Assert
            //Assert.Equal(result, "Fizz");
            result.Should().Be("Fizz");
        }
    }
}
