using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using ClinicFrontDesk.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ClinicFrontDesk.Tests.Infrastructure
{
    public class AppointmentRepositoryTests
    {
        private ClinicDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ClinicDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new ClinicDbContext(options);
        }

        [Fact]
        public async Task CanAddAndRetrieveAppointment()
        {
            var context = GetDbContext();
            var repo = new AppointmentRepository(context);
            var appointment = new Appointment { PatientId = 1, Clinic = "Main Clinic", AppointmentType = "Checkup", DateTime = DateTime.Now, Status = "Scheduled" };
            await repo.AddAsync(appointment);
            var retrieved = await repo.GetByIdAsync(appointment.Id);
            Assert.NotNull(retrieved);
            Assert.Equal("Main Clinic", retrieved!.Clinic);
        }
    }
}