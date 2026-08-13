using FizzBuzz.Api.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private readonly Fizz_Buzz _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new Fizz_Buzz();
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void Multiple_of_ShouldReturnTrue_WhenNumberIsDivisibleBy3And5(int number)
        {
            // Act
            var result = _fizzBuzz.Multiple_of(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void Multiple_of_ShouldReturnFalse_WhenNumberIsNotDivisibleBy3And5(int number)
        {
            // Act
            var result = _fizzBuzz.Multiple_of(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetResult_ShouldReturnFizzBuzz()
        {
            // Act
            var result = _fizzBuzz.GetResult(15);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }
    }
}
