

using FizzBuzz.Api.Service;

namespace FizzBuzz.Api.Interface
{
    public interface IFizzBuzzFactory
    {
        Fizz CreateFizz();

        Buzz CreateBuzz();

        Fizz_Buzz CreateFizzBuzz();
    }
}
