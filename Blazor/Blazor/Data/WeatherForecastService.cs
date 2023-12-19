using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate, int days = 5)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, days).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                City = "Stockholm",
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
