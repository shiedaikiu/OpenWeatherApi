using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenWeatherApi.Services;

namespace OpenWeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public EnvironmentController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> Get(string city)
        {
            var result = await _weatherService.GetEnvironmentDataAsync(city);
            if (result == null)
                return NotFound(new { Message = $"City '{city}' not found." });

            return Ok(result);
        }
    }
}
