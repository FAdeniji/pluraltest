using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ClinicFrontDesk.Infrastructure.Services
{
    public class WalletService : IWalletService
    {
        private readonly ClinicDbContext _context;
        public WalletService(ClinicDbContext context)
        {
            _context = context;
        }

        public async Task<decimal> GetBalanceAsync(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            return patient?.WalletBalance ?? 0;
        }

        public async Task<bool> DeductAsync(int patientId, decimal amount)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient == null || patient.WalletBalance < amount) return false;
            patient.WalletBalance -= amount;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreditAsync(int patientId, decimal amount)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient == null) return false;
            patient.WalletBalance += amount;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}