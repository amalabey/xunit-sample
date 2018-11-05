using System;
using fizzbuzz.services;
using Xunit;
using FluentAssertions;
using NSubstitute;

namespace fizzbuzz.unittests
{
    public class GreeterServiceTests{
        [Theory]
        [InlineData("John", 8, "Good morning, John")]
        [InlineData("Jane Doe", 14, "Good afternoon, Jane Doe")]
        public void GetGreetingWithNameReturnsGoodAfternoonName(string name, int hour, string expected)
        {
            // Arrange
            var mockTimeService = Substitute.For<ITimeService>();
            mockTimeService.Now().Returns(new DateTime(1900, 1, 1, hour, 0, 0));

            var service = new GreeterService(mockTimeService);

            // Act
            var greeting = service.GetGreeting(name);
            
            // Assert
            greeting.Should().Be(expected);
        }
    }
}