using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ClinicFrontDesk.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ClinicDbContext _context;
        public AppointmentRepository(ClinicDbContext context)
        {
            _context = context;
        }

        public async Task<Appointment?> GetByIdAsync(int id) => await _context.Appointments.FindAsync(id);

        public async Task<IEnumerable<Appointment>> GetByPatientIdAsync(int patientId) => await _context.Appointments.Where(a => a.PatientId == patientId).ToListAsync();

        public async Task<IEnumerable<Appointment>> GetAllAsync() => await _context.Appointments.ToListAsync();

        public async Task AddAsync(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }
    }
}