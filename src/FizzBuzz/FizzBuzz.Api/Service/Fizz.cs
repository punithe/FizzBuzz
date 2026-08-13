using FizzBuzz.Api.Interface;

namespace FizzBuzz.Api.Service
{
    public class Fizz : IFizzBuzz
    {
        public bool Multiple_of(int number)
        {
            return number % 3 == 0;
        }
        public string GetResult(int number)
        {
            return "Fizz";
        }
    }
}
