using FizzBuzz.Api.Interface;
using FizzBuzz.Api.Service;

namespace FizzBuzz.Api.Factories
{
    public class FizzBuzzFactory : IFizzBuzzFactory
    {
        public Fizz CreateFizz()
        {
            return new Fizz();
        }

        public Buzz CreateBuzz()
        {
            return new Buzz();
        }

        public Fizz_Buzz CreateFizzBuzz()
        {
            return new Fizz_Buzz();
        }
    }
}
