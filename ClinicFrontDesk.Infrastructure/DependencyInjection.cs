using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClinicFrontDesk.Infrastructure.Persistence;

namespace ClinicFrontDesk.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClinicDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<Application.Interfaces.IPatientRepository, Repositories.PatientRepository>();
            services.AddScoped<Application.Interfaces.IAppointmentRepository, Repositories.AppointmentRepository>();
            services.AddScoped<Application.Interfaces.IInvoiceRepository, Repositories.InvoiceRepository>();
            services.AddScoped<Application.Interfaces.IWalletService, Services.WalletService>();
            return services;
        }
    }
}