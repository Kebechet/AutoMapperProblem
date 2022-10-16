using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly TestingService _testingService;

        public WeatherForecastController(TestingService testingService)
        {
            _testingService = testingService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            _testingService.Test();

            return Ok();
        }
    }
}