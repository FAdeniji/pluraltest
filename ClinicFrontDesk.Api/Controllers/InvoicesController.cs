using ClinicFrontDesk.Application.Interfaces;
using ClinicFrontDesk.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicFrontDesk.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IWalletService _walletService;

        public InvoicesController(IInvoiceRepository invoiceRepository, IWalletService walletService)
        {
            _invoiceRepository = invoiceRepository;
            _walletService = walletService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            await _invoiceRepository.AddAsync(invoice);
            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.Id }, invoice);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoice(int id)
        {
            var invoice = await _invoiceRepository.GetByIdAsync(id);
            if (invoice == null) return NotFound();
            return Ok(invoice);
        }

        [HttpPost("{id}/pay-wallet")]
        public async Task<IActionResult> PayInvoiceWithWallet(int id)
        {
            var invoice = await _invoiceRepository.GetByIdAsync(id);
            if (invoice == null) return NotFound();
            var success = await _walletService.DeductAsync(invoice.PatientId, invoice.Total - invoice.Discount);
            if (!success) return BadRequest("Insufficient wallet balance");
            invoice.Status = "Paid";
            await _invoiceRepository.UpdateAsync(invoice);
            return Ok(invoice);
        }
    }
}