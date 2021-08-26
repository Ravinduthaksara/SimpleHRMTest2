using AutoMapper;
using FluentAssertions;
using NUnit.Framework;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.Models;
using System.Collections.Generic;

namespace PeachIT.HRMLite.BL.Test
{
    public class WeatherServiceTests : TestBase
    {
        private IWeatherService service;

        [SetUp]
        public void Setup()
        {
            service = (IWeatherService)services.GetService(typeof(IWeatherService));
        }

        [Test]
        public void GetAllForecast_ShouldNotReturnData()
        {
            var result = service.GetWeatherForecast();

            result.Count.Should().BeGreaterOrEqualTo(1);
            result.Should().BeOfType<List<WeatherForecastModel>>();
        }
    }
}