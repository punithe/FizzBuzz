using FizzBuzz.Api.Interface;

namespace FizzBuzz.Api.Service
{
    public class Buzz : IFizzBuzz
    {
        public bool Multiple_of(int number)
        {
            return number % 5 == 0;
        }
        public string GetResult(int number)
        {
            return "Buzz";
        }
    }
}
