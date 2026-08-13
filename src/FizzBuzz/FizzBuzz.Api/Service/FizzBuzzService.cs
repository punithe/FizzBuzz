using FizzBuzz.Api.Interface;
using FizzBuzz.Api.Model;

namespace FizzBuzz.Api.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IFizzBuzzFactory _Factory;

        /// <summary>
        /// Initializes the FizzBuzz service.
        /// 
        /// The rule factory is provided through Dependency Injection.
        /// </summary>
        /// <param name="ruleFactory">Factory used to obtain FizzBuzz rules.</param>
        public FizzBuzzService(IFizzBuzzFactory Factory)
        {
            _Factory = Factory;
        }

        /// <summary>
        /// Processes every value supplied in the request.
        /// </summary>
        public FizzBuzzResponse CheckFizzBuzz(FizzBuzzRequest request)
        {
            var response = new FizzBuzzResponse();

            // Get the rules from the factory instead of
            // creating the rule objects directly here.
            var fizz = _Factory.CreateFizz();
            var buzz = _Factory.CreateBuzz();
            var fizzBuzz = _Factory.CreateFizzBuzz();

            foreach (var value in request.Values)
            {
                if (!int.TryParse(value, out var number))
                {
                    response.Results[value] = new List<string>
                   {
                      "Invalid Item"
                   };

                    continue;
                }

                // Check whether the number is divisible by both 3 and 5.
                if (number % 3 == 0 && number % 5 == 0)
                {
                    response.Results[value] = new List<string>
                   {
                      "FizzBuzz"
                   };
                }
                // Check whether the number is divisible by 3.
                else if (number % 3 == 0)
                {
                    response.Results[value] = new List<string>
                   {
                      "Fizz"
                   };
                }
                // Check whether the number is divisible by 5.
                else if (number % 5 == 0)
                {
                    response.Results[value] = new List<string>
                   {
                      "Buzz"
                   };
                }
                // Number is not divisible by 3 or 5.
                else
                {
                    response.Results[value] = new List<string>
                   {
                       $"Divided {number} by 3",
                       $"Divided {number} by 5"
                   };
                }
            }

            return response;
        }
    }
}
