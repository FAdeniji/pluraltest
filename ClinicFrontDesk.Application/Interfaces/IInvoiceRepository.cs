using ClinicFrontDesk.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicFrontDesk.Application.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<Invoice?> GetByIdAsync(int id);
        Task<IEnumerable<Invoice>> GetByPatientIdAsync(int patientId);
        Task AddAsync(Invoice invoice);
        Task UpdateAsync(Invoice invoice);
    }
}