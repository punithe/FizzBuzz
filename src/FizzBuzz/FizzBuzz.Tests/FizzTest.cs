using FizzBuzz.Api.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Tests
{
    public class FizzTest
    {
        private readonly Fizz _fizz;

        public FizzTest()
        {
            _fizz = new Fizz();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Multiple_of_ShouldReturnTrue_WhenNumberIsDivisibleBy3(int number)
        {
            // Act
            var result = _fizz.Multiple_of(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Multiple_of_ShouldReturnFalse_WhenNumberIsNotDivisibleBy3(int number)
        {
            // Act
            var result = _fizz.Multiple_of(number);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(15)]
        public void GetResult_ShouldReturnFizz(int number)
        {
            // Act
            var result = _fizz.GetResult(number);

            // Assert
            Assert.Equal("Fizz", result);
        }

    }
}
