using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using ClinicFrontDesk.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;

namespace ClinicFrontDesk.Tests.Infrastructure
{
    public class WalletServiceTests
    {
        private ClinicDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ClinicDbContext>()
                .UseInMemoryDatabase(databaseName: "WalletTestDb")
                .Options;
            return new ClinicDbContext(options);
        }

        [Fact]
        public async Task CanCreditAndDeductWallet()
        {
            var context = GetDbContext();
            var patient = new Patient { Name = "Wallet User", Code = "W1", WalletBalance = 100 };
            context.Patients.Add(patient);
            await context.SaveChangesAsync();
            var service = new WalletService(context);
            var credited = await service.CreditAsync(patient.Id, 50);
            Assert.True(credited);
            Assert.Equal(150, (await service.GetBalanceAsync(patient.Id)));
            var deducted = await service.DeductAsync(patient.Id, 70);
            Assert.True(deducted);
            Assert.Equal(80, (await service.GetBalanceAsync(patient.Id)));
        }
    }
}