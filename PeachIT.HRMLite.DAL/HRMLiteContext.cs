using Microsoft.EntityFrameworkCore;
using PeachIT.HRMLite.Domain;

namespace PeachIT.HRMLite.DAL
{
    public class HRMLiteContext : DbContext
    {
        public HRMLiteContext(DbContextOptions<HRMLiteContext> options) : base(options) { }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
