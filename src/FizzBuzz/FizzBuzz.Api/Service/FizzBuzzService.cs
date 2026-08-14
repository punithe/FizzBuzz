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
                    response.Results.Add(new FizzBuzzResult
                    {
                        Value = value,
                        Result = new List<string>
                        {
                            "Invalid Item"
                        }
                    });
                    continue;
                }
                if (fizzBuzz.Multiple_of(number))
                {
                    response.Results.Add(new FizzBuzzResult
                    {
                        Value = value,
                        Result = new List<string>
                        {
                            fizzBuzz.GetResult(number)
                        }
                    });
                }
                else if (fizz.Multiple_of(number))
                {
                    response.Results.Add(new FizzBuzzResult
                    {
                        Value = value,
                        Result = new List<string>
                        {
                            fizz.GetResult(number)
                        }
                    });
                }
                else if (buzz.Multiple_of(number))
                {
                    response.Results.Add(new FizzBuzzResult
                    {
                        Value = value,
                        Result = new List<string>
                        {
                            buzz.GetResult(number)
                        }
                    });
                }
                else
                {
                    response.Results.Add(new FizzBuzzResult
                    {
                        Value = value,
                        Result = new List<string>
                        {
                            $"Divided {number} by 3",
                            $"Divided {number} by 5"
                        }
                    });
                }
            }
            return response;
        }
    }
}
