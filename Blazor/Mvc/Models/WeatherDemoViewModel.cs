using Mvc.Data;

namespace Mvc.Models
{
    public class WeatherDemoViewModel
    {
        public string City { get; set; } = string.Empty;
        public WeatherForecast[] Forecasts { get; set; } = Array.Empty<WeatherForecast>();
    }
}
