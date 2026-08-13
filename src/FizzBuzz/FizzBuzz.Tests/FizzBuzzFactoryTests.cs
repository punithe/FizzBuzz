using FizzBuzz.Api.Factories;
using FizzBuzz.Api.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Tests
{
    public class FizzBuzzFactoryTests
    {
        private readonly FizzBuzzFactory _factory;

        public FizzBuzzFactoryTests()
        {
            // Arrange
            _factory = new FizzBuzzFactory();
        }

        [Fact]
        public void CreateFizz_ShouldReturnFizzObject()
        {
            // Act
            var result = _factory.CreateFizz();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Fizz>(result);
        }

        [Fact]
        public void CreateBuzz_ShouldReturnBuzzObject()
        {
            // Act
            var result = _factory.CreateBuzz();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Buzz>(result);
        }

        [Fact]
        public void CreateFizzBuzz_ShouldReturnFizzBuzzObject()
        {
            // Act
            var result = _factory.CreateFizzBuzz();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Fizz_Buzz>(result);
        }
    }
}
