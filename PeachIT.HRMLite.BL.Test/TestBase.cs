using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeachIT.HRMLite.DAL;
using PeachIT.HRMLite.Infrastructure;

namespace PeachIT.HRMLite.BL.Test
{
    public class TestBase
    {
        internal ServiceProvider services;
        internal HRMLiteContext context;

        public TestBase()
        {
            var configuration = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json")
               .Build();
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddDbContext<HRMLiteContext>(options =>
                {
                    options.UseInMemoryDatabase("BRTDB");
                });
            DIContainer.Initialize(serviceCollection);
            services = serviceCollection.BuildServiceProvider();


            context = (HRMLiteContext)services.GetService(typeof(HRMLiteContext));
            context.SeedAll();
        }
    }
}