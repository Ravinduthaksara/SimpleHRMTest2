using PeachIT.HRMLite.Models;
using System.Collections.Generic;

namespace PeachIT.HRMLite.Contracts
{
    public interface IWeatherService
    {
        List<WeatherForecastModel> GetWeatherForecast();
    }
}
