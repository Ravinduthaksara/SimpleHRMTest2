using AutoMapper;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Models;

namespace PeachIT.HRMLite.Infrastructure
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<WeatherForecast, WeatherForecastModel>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<Department, DepartmentModel>().ReverseMap();
        }
    }
}
