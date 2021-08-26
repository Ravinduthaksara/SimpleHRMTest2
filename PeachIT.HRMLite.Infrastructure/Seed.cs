using PeachIT.HRMLite.DAL;
using PeachIT.HRMLite.Domain;
using System;
using System.Linq;

namespace PeachIT.HRMLite.Infrastructure
{
    public static class Seed
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static HRMLiteContext SeedAll(this HRMLiteContext context)
        {
            var rng = new Random();
            var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            context.WeatherForecasts.AddRange(forecasts);
            context.SaveChanges();
            return context;
        }
    }
}
