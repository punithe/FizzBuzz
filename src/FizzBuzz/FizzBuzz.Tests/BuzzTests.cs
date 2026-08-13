using FizzBuzz.Api.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Tests
{
    public class BuzzTests
    {
        private readonly Buzz _buzz;

        public BuzzTests()
        {
            _buzz = new Buzz();
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Multiple_of_ShouldReturnTrue_WhenNumberIsDivisibleBy5(int number)
        {
            // Act
            var result = _buzz.Multiple_of(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(7)]
        public void Multiple_of_ShouldReturnFalse_WhenNumberIsNotDivisibleBy5(int number)
        {
            // Act
            var result = _buzz.Multiple_of(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetResult_ShouldReturnBuzz()
        {
            // Act
            var result = _buzz.GetResult(5);

            // Assert
            Assert.Equal("Buzz", result);
        }
    }
}
