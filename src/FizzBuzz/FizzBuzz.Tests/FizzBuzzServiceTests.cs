using FizzBuzz.Api.Factories;
using FizzBuzz.Api.Interface;
using FizzBuzz.Api.Model;
using FizzBuzz.Api.Service;
using Moq;

namespace FizzBuzz.Tests;

public class FizzBuzzServiceTests
{
    private readonly FizzBuzzService _service;
    public FizzBuzzServiceTests()
    {
        var factory = new FizzBuzzFactory();

        _service = new FizzBuzzService(factory);
    }

    [Fact]
    public void CheckFizz_WhenNumberIsDivisibleBy3_ReturnsFizz()
    {
        // Arrange
        var request = new FizzBuzzRequest
        {
            Values = new List<string> { "3" }
        };

        // Act
        var response = _service.CheckFizzBuzz(request);
        var result = response.Results.First(r => r.Value == "3");

        // Assert
        Assert.Equal(
            new List<string> { "Fizz" },
            result.Result);
    }

    [Fact]
    public void CheckBuzz_WhenNumberIsDivisibleBy5_ReturnsBuzz()
    {
        // Arrange
        var request = new FizzBuzzRequest
        {
            Values = new List<string> { "5" }
        };

        // Act
        var response = _service.CheckFizzBuzz(request);
        var result = response.Results.First(r => r.Value == "5");

        // Assert
        Assert.Equal(
            new List<string> { "Buzz" },
            result.Result);
    }

    [Fact]
    public void CheckFizzBuzz_WhenNumberIsDivisibleBy3And5_ReturnsFizzBuzz()
    {
        // Arrange
        var request = new FizzBuzzRequest
        {
            Values = new List<string> { "15" }
        };

        // Act
        var response = _service.CheckFizzBuzz(request);
        var result = response.Results.First(r => r.Value == "15");

        // Assert
        Assert.Equal(
            new List<string> { "FizzBuzz" },
            result.Result);
    }

    [Fact]
    public void CheckFizzBuzz_WhenNumberIsNotDivisibleByNum_ReturnsDivisionMessages()
    {
        // Arrange
        var number = 7;

        var request = new FizzBuzzRequest
        {
            Values = new List<string> { number.ToString() }
        };

        // Act
        var response = _service.CheckFizzBuzz(request);
        var result = response.Results.First(r => r.Value == "7");

        // Assert
        Assert.Equal(
            new List<string>
            {
                $"Divided {number} by 3",
                $"Divided {number} by 5"
            },
            result.Result);
    }

    [Fact]
    public void CheckFizzBuzz_WhenValueIsInvalid_ReturnsInvalidItem()
    {
        // Arrange
        var request = new FizzBuzzRequest
        {
            Values = new List<string> { "abc" }
        };

        // Act
        var response = _service.CheckFizzBuzz(request);
        var result = response.Results.First(r => r.Value == "abc");

        // Assert
        Assert.Equal(
            new List<string> { "Invalid Item" },
            result.Result);
    }

    [Fact]
    public void CheckFizzBuzz_WhenValueIsNull_ReturnsInvalidItem()
    {
        // Arrange
        var request = new FizzBuzzRequest
        {
            Values = new List<string?> { null }
        };

        // Act
        var response = _service.CheckFizzBuzz(request);
        var result = response.Results.First(r => r.Value == null);

        // Assert
        Assert.Equal(
            new List<string> { "Invalid Item" },
            result.Result);
    }
}
