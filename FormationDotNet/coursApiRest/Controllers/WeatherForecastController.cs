using Microsoft.AspNetCore.Mvc;

namespace coursApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
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
        public IActionResult GetOne(int id)
        {
            return Ok(new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = id,
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }

        [HttpPost]
        public IActionResult Post([FromForm] string meteo, [FromForm] string ville, [FromForm] IFormFile image)
        {
            return Ok();
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] object data)
        //{
        //    return Ok();
        //}

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] object data, int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}