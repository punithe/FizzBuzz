using FizzBuzz.Api.Interface;

namespace FizzBuzz.Api.Service
{
    public class Fizz_Buzz : IFizzBuzz
    {
        public bool Multiple_of(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public string GetResult(int number)
        {
            return "FizzBuzz";
        }
    }
}
