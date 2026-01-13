using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ClinicFrontDesk.Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ClinicDbContext _context;
        public InvoiceRepository(ClinicDbContext context)
        {
            _context = context;
        }

        public async Task<Invoice?> GetByIdAsync(int id) => await _context.Invoices.Include(i => i.Items).FirstOrDefaultAsync(i => i.Id == id);

        public async Task<IEnumerable<Invoice>> GetByPatientIdAsync(int patientId) => await _context.Invoices.Where(i => i.PatientId == patientId).Include(i => i.Items).ToListAsync();

        public async Task AddAsync(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
        }
    }
}