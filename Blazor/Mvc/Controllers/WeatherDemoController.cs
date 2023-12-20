using Microsoft.AspNetCore.Mvc;
using Mvc.Data;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class WeatherDemoController : Controller
    {
        private readonly WeatherForecastService _weatherForecastService;

        public WeatherDemoController(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int numberOfDays = 5)
        {
            var forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now, numberOfDays);

            var model = new WeatherDemoViewModel
            {
                Forecasts = forecasts,
                City = FetchRandomCity()
            };

            return View(model);
        }


        private string FetchRandomCity()
        {
            List<string> cities = new List<string>
            {
                "New York",
                "Los Angeles",
                "Chicago",
                "Houston",
                "Phoenix",
                "Philadelphia",
                "San Antonio",
                "San Diego",
                "Dallas",
                "San Jose"
            };

            Random random = new Random();
            int randomIndex = random.Next(cities.Count);

            return cities[randomIndex];
        }
    }
}
