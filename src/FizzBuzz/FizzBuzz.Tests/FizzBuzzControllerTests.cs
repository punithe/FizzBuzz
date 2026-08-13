using FizzBuzz.Api.Controllers;
using FizzBuzz.Api.Interface;
using FizzBuzz.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Tests
{
    public class FizzBuzzControllerTests
    {
        private readonly Mock<IFizzBuzzService> _serviceMock;
        private readonly FizzBuzzController _controller;

        public FizzBuzzControllerTests()
        {
            _serviceMock = new Mock<IFizzBuzzService>();

            _controller = new FizzBuzzController(_serviceMock.Object);
        }

        [Fact]
        public void CheckFizzBuzz_ShouldReturnOkResult()
        {
            // Arrange
            var request = new FizzBuzzRequest
            {
                Values = new List<string> { "3" }
            };

            var expectedResponse = new FizzBuzzResponse();

            _serviceMock
                .Setup(x => x.CheckFizzBuzz(request))
                .Returns(expectedResponse);

            // Act
            var result = _controller.CheckFizzBuzz(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);

            Assert.Equal(200, okResult.StatusCode);
            Assert.Same(expectedResponse, okResult.Value);
        }

    }
}
