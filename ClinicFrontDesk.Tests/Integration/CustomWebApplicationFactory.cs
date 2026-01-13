using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using ClinicFrontDesk.Api;
using ClinicFrontDesk.Infrastructure.Persistence;

namespace ClinicFrontDesk.Tests.Integration
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Remove the app's DbContext registration.
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<ClinicDbContext>));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }
                // Add DbContext using in-memory database for testing.
                services.AddDbContext<ClinicDbContext>(options =>
                {
                    options.UseInMemoryDatabase("TestDb");
                });
            });
            return base.CreateHost(builder);
        }
    }
}
