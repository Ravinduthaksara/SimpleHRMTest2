using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PeachIT.HRMLite.DAL;
using PeachIT.HRMLite.Infrastructure;
using System.Linq;

namespace PeachIT.HRMLite.API.Seed
{
    public static class Extentions
    {
        public static void TrySeedDb(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<HRMLiteContext>();
            if (context.Employees.Any())
            {
                return;
            }
            context.SeedAll();
        }
    }
}
