using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-40, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();


            foreach (var res in results)
            {

                res.Summary = res.TemperatureC switch
                {
                    < -32 => "Well bellow frezzing",
                    >= -32 and < 0 => "Cold",
                    15 => "Warm",
                    >= 30 => "Hot",
                    _ => "Unknown"
                };


            }

            return Task.FromResult(results);
        }
    }
}
