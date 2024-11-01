using Microsoft.AspNetCore.Mvc;

namespace DesafioTecnico_DevJunior.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<UserDBContexst> httpGet();
        
            
public class UserDBContext
        {
            public DateOnly Date { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }
        }

        // Example summaries for demonstration purposes
        public static class Program
        {
            private static readonly string[] Summaries = new[]
            {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild",
        "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

            public static void Main()
            {
                var weatherData = Enumerable.Range(1, 5).Select(index => new UserDBContext
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                }).ToList();

                // Output the generated data
                foreach (var entry in weatherData)
                {
                    Console.WriteLine($"Date: {entry.Date}, Temp: {entry.TemperatureC}, Summary: {entry.Summary}");
                }
            }
        }

    }
            
        }
    

