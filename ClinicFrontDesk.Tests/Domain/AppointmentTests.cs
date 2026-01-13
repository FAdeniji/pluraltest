using ClinicFrontDesk.Domain.Entities;
using Xunit;

namespace ClinicFrontDesk.Tests.Domain
{
    public class AppointmentTests
    {
        [Fact]
        public void CanCreateAppointment_WithValidData()
        {
            var appointment = new Appointment
            {
                PatientId = 1,
                Clinic = "Main Clinic",
                AppointmentType = "Consultation",
                DateTime = new DateTime(2026, 1, 13, 10, 0, 0),
                Status = "Scheduled"
            };
            Assert.Equal(1, appointment.PatientId);
            Assert.Equal("Main Clinic", appointment.Clinic);
            Assert.Equal("Consultation", appointment.AppointmentType);
            Assert.Equal(new DateTime(2026, 1, 13, 10, 0, 0), appointment.DateTime);
            Assert.Equal("Scheduled", appointment.Status);
        }
    }
}