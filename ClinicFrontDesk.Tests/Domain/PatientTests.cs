using ClinicFrontDesk.Domain.Entities;
using Xunit;

namespace ClinicFrontDesk.Tests.Domain
{
    public class PatientTests
    {
        [Fact]
        public void CanCreatePatient_WithValidData()
        {
            var patient = new Patient
            {
                Name = "John Doe",
                Code = "P123",
                Phone = "555-1234",
                Clinic = "Main Clinic",
                WalletBalance = 100.0m,
                Currency = "USD"
            };
            Assert.Equal("John Doe", patient.Name);
            Assert.Equal("P123", patient.Code);
            Assert.Equal("555-1234", patient.Phone);
            Assert.Equal("Main Clinic", patient.Clinic);
            Assert.Equal(100.0m, patient.WalletBalance);
            Assert.Equal("USD", patient.Currency);
        }
    }
}