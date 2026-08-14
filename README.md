# FizzBuzz

## Introduction
FizzBuzz is a simple ASP.NET Core Web API application developed as part of a coding exercise.

The application accepts an array of values and processes each value according to the following rules:

1. If the value is divisible by 3, return `Fizz`.
2. If the value is divisible by 5, return `Buzz`.
3. If the value is divisible by both 3 and 5, return `FizzBuzz`.
4. If the value is not divisible by 3 or 5, display the division messages.
5. If the value is empty or not a valid number, return `Invalid Item`.

---------------------------------------------------------------------------------
#input
```json
{
  "values": [
    "1",
    "3",
    "5",
    "15",
    "23",
    "A"
  ]
}
-----------------------------------------------------------------------------------
# Output
{
  "results": {
    "1": [
      "Divided 1 by 3",
      "Divided 1 by 5"
    ],
    "3": [
      "Fizz"
    ],
    "5": [
      "Buzz"
    ],
    "15": [
      "FizzBuzz"
    ],
    "23": [
      "Divided 23 by 3",
      "Divided 23 by 5"
    ],
    "A": [
      "Invalid Item"
    ]
  }
}
-----------------------------------------------------------------------------
# Technology 
C#
ASP.NET Core Web API
.NET
Swagger 
xUnit
Dependency Injection
Factory Design Pattern
------------------------------------------------------------------------------
# Single Responsibility Principle
The application separates responsibilities between different components.
Controller handles HTTP requests and responses.
Service handles the FizzBuzz processing.
Factory is responsible for creating FizzBuzz-related objects.
Models represent request and response data.
Unit tests verify application behavior.
