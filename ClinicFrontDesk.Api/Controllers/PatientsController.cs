using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicFrontDesk.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IWalletService _walletService;

        public PatientsController(IPatientRepository patientRepository, IAppointmentRepository appointmentRepository, IWalletService walletService)
        {
            _patientRepository = patientRepository;
            _appointmentRepository = appointmentRepository;
            _walletService = walletService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients([FromQuery] string? name, [FromQuery] string? code, [FromQuery] string? phone, [FromQuery] string? clinic, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int page = 1, [FromQuery] int pageSize = 20, [FromQuery] string sortBy = "name", [FromQuery] bool ascending = true)
        {
            var patients = await _patientRepository.SearchAsync(name, code, phone, clinic, from, to, page, pageSize, sortBy, ascending);
            var total = await _patientRepository.GetTotalCountAsync(name, code, phone, clinic, from, to);
            return Ok(new { items = patients, total });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await _patientRepository.GetByIdAsync(id);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        [HttpGet("{id}/wallet")]
        public async Task<IActionResult> GetWalletBalance(int id)
        {
            var balance = await _walletService.GetBalanceAsync(id);
            return Ok(new { balance });
        }
    }
}