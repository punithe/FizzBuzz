using FizzBuzz.Api.Interface;
using FizzBuzz.Api.Model;

namespace FizzBuzz.Api.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IFizzBuzzFactory _Factory;

        public FizzBuzzService(IFizzBuzzFactory Factory)
        {
            _Factory = Factory;
        }

        public FizzBuzzResponse CheckFizzBuzz(FizzBuzzRequest request)
        {
            var response = new FizzBuzzResponse();

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
                if (number % 3 == 0 && number % 5 == 0)
                {
                    response.Results[value] = new List<string>
                   {
                      "FizzBuzz"
                   };
                }
                else if (number % 3 == 0)
                {
                    response.Results[value] = new List<string>
                   {
                      "Fizz"
                   };
                }
                else if (number % 5 == 0)
                {
                    response.Results[value] = new List<string>
                   {
                      "Buzz"
                   };
                }
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
