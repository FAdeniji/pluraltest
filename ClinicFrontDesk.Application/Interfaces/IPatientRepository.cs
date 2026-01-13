using ClinicFrontDesk.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicFrontDesk.Application.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient?> GetByIdAsync(int id);
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<IEnumerable<Patient>> SearchAsync(string? name, string? code, string? phone, string? clinic, DateTime? from, DateTime? to, int page, int pageSize, string sortBy, bool ascending);
        Task<int> GetTotalCountAsync(string? name, string? code, string? phone, string? clinic, DateTime? from, DateTime? to);
        Task AddAsync(Patient patient);
        Task UpdateAsync(Patient patient);
    }
}