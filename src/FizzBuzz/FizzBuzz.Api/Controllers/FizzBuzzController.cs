using FizzBuzz.Api.Interface;
using FizzBuzz.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public ActionResult<FizzBuzzResponse> CheckFizzBuzz(FizzBuzzRequest request)
        {       
            var response = _fizzBuzzService.CheckFizzBuzz(request);

            return Ok(response);
        }
    }
}
