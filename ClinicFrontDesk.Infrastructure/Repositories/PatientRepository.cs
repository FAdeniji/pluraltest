using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ClinicFrontDesk.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ClinicDbContext _context;
        public PatientRepository(ClinicDbContext context)
        {
            _context = context;
        }

        public async Task<Patient?> GetByIdAsync(int id) => await _context.Patients.FindAsync(id);

        public async Task<IEnumerable<Patient>> GetAllAsync() => await _context.Patients.ToListAsync();

        public async Task<IEnumerable<Patient>> SearchAsync(string? name, string? code, string? phone, string? clinic, DateTime? from, DateTime? to, int page, int pageSize, string sortBy, bool ascending)
        {
            var query = _context.Patients.AsQueryable();
            if (!string.IsNullOrEmpty(name)) query = query.Where(p => p.Name.Contains(name));
            if (!string.IsNullOrEmpty(code)) query = query.Where(p => p.Code.Contains(code));
            if (!string.IsNullOrEmpty(phone)) query = query.Where(p => p.Phone.Contains(phone));
            if (!string.IsNullOrEmpty(clinic)) query = query.Where(p => p.Clinic == clinic);
            // Add time window filtering if needed (requires appointment join)
            // Sorting
            query = sortBy switch
            {
                "name" => ascending ? query.OrderBy(p => p.Name) : query.OrderByDescending(p => p.Name),
                _ => ascending ? query.OrderBy(p => p.Id) : query.OrderByDescending(p => p.Id)
            };
            return await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<int> GetTotalCountAsync(string? name, string? code, string? phone, string? clinic, DateTime? from, DateTime? to)
        {
            var query = _context.Patients.AsQueryable();
            if (!string.IsNullOrEmpty(name)) query = query.Where(p => p.Name.Contains(name));
            if (!string.IsNullOrEmpty(code)) query = query.Where(p => p.Code.Contains(code));
            if (!string.IsNullOrEmpty(phone)) query = query.Where(p => p.Phone.Contains(phone));
            if (!string.IsNullOrEmpty(clinic)) query = query.Where(p => p.Clinic == clinic);
            // Add time window filtering if needed
            return await query.CountAsync();
        }

        public async Task AddAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
        }
    }
}