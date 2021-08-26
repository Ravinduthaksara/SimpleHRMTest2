using AutoMapper;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.DAL;
using PeachIT.HRMLite.Models;
using System.Collections.Generic;
using System.Linq;

namespace PeachIT.HRMLite.BL
{
    public class WeatherService : IWeatherService
    {
        private readonly HRMLiteContext context;
        private readonly IMapper mapper;

        public WeatherService(HRMLiteContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<WeatherForecastModel> GetWeatherForecast()
        {
            var forecasts = context.WeatherForecasts.ToList();
            return mapper.Map<List<WeatherForecastModel>>(forecasts);
        }
    }
}
