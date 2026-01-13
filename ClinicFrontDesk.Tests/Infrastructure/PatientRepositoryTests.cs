using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using ClinicFrontDesk.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;

namespace ClinicFrontDesk.Tests.Infrastructure
{
    public class PatientRepositoryTests
    {
        private ClinicDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ClinicDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            return new ClinicDbContext(options);
        }

        [Fact]
        public async Task CanAddAndRetrievePatient()
        {
            var context = GetDbContext();
            var repo = new PatientRepository(context);
            var patient = new Patient { Name = "Jane Doe", Code = "P456", Phone = "555-5678", Clinic = "Branch Clinic", WalletBalance = 50, Currency = "USD" };
            await repo.AddAsync(patient);
            var retrieved = await repo.GetByIdAsync(patient.Id);
            Assert.NotNull(retrieved);
            Assert.Equal("Jane Doe", retrieved!.Name);
        }
    }
}