using System.Threading.Tasks;

namespace ClinicFrontDesk.Application.Interfaces
{
    public interface IWalletService
    {
        Task<decimal> GetBalanceAsync(int patientId);
        Task<bool> DeductAsync(int patientId, decimal amount);
        Task<bool> CreditAsync(int patientId, decimal amount);
    }
}