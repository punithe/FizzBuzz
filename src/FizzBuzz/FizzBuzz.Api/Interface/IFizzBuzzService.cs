using FizzBuzz.Api.Model;

namespace FizzBuzz.Api.Interface
{
    public interface IFizzBuzzService
    {
        FizzBuzzResponse CheckFizzBuzz(FizzBuzzRequest request);
    }
}
