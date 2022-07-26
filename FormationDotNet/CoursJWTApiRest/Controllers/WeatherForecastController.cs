using CoursJWTApiRest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoursJWTApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private TokenService _tokenService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, TokenService tokenService)
        {
            _logger = logger;
            _tokenService = tokenService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        
        public WeatherForecast Get(int id)
        {
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = id               
            };
        }
        [HttpGet("token")]
        [AllowAnonymous]
        public string GetToken()
        {
            return _tokenService.Authenticate("toto", "tata");
        }
    }
}