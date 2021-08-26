using Microsoft.Extensions.DependencyInjection;
using PeachIT.HRMLite.BL;
using PeachIT.HRMLite.Contracts;

namespace PeachIT.HRMLite.Infrastructure
{
    public class DIContainer
    {
        public static IServiceCollection Initialize(IServiceCollection services)
        {
            services.AddTransient<IWeatherService, WeatherService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddAutoMapper(typeof(MapConfiguration));

            return services;
        }
    }
}
