using ClinicFrontDesk.Domain.Entities;
using Xunit;
using System.Collections.Generic;

namespace ClinicFrontDesk.Tests.Domain
{
    public class InvoiceTests
    {
        [Fact]
        public void CanCreateInvoice_WithItemsAndDiscount()
        {
            var items = new List<InvoiceItem>
            {
                new InvoiceItem { Description = "Consultation", Amount = 100 },
                new InvoiceItem { Description = "X-Ray", Amount = 50 }
            };
            var invoice = new Invoice
            {
                PatientId = 1,
                Date = new DateTime(2026, 1, 13),
                Total = 150,
                Discount = 10,
                Status = "Unpaid",
                Items = items
            };
            Assert.Equal(1, invoice.PatientId);
            Assert.Equal(new DateTime(2026, 1, 13), invoice.Date);
            Assert.Equal(150, invoice.Total);
            Assert.Equal(10, invoice.Discount);
            Assert.Equal("Unpaid", invoice.Status);
            Assert.Equal(2, invoice.Items.Count);
        }
    }
}