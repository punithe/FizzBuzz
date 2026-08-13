namespace FizzBuzz.Api.Model
{
    public class FizzBuzzResponse
    {
        public Dictionary<string, List<string>> Results { get; set; } = new();
    }
}
