using System;
using fizzbuzz.services;
using Xunit;
using FluentAssertions;
using NSubstitute;

namespace fizzbuzz.unittests
{
    public class GreeterServiceTests{
        [Theory]
        [InlineData("John")]
        [InlineData("Jane Doe")]
        public void GetGreetingWithNameReturnsGoodAfternoonName(string name)
        {
            // Arrange
            var service = new GreeterService();

            // Act
            var greeting = service.GetGreeting(name);
            
            // Assert
            greeting.Should().Be($"Good afternoon, {name}");
        }
    }
}