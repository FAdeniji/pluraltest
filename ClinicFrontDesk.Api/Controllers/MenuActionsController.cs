using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicFrontDesk.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MenuActionsController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public MenuActionsController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpPost("move-to-awaiting-vitals/{appointmentId}")]
        public async Task<IActionResult> MoveToAwaitingVitals(int appointmentId)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null) return NotFound();
            appointment.Status = "Awaiting Vitals";
            await _appointmentRepository.UpdateAsync(appointment);
            return Ok(appointment);
        }
    }
}