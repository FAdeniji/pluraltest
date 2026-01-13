using ClinicFrontDesk.Domain.Entities;
using ClinicFrontDesk.Infrastructure.Persistence;
using ClinicFrontDesk.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ClinicFrontDesk.Tests.Infrastructure
{
    public class InvoiceRepositoryTests
    {
        private ClinicDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ClinicDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new ClinicDbContext(options);
        }

        [Fact]
        public async Task CanAddAndRetrieveInvoiceWithItems()
        {
            var context = GetDbContext();
            var repo = new InvoiceRepository(context);
            var items = new List<InvoiceItem> { new InvoiceItem { Description = "Test", Amount = 10 } };
            var invoice = new Invoice { PatientId = 1, Date = DateTime.Now, Total = 10, Discount = 0, Status = "Unpaid", Items = items };
            await repo.AddAsync(invoice);
            var retrieved = await repo.GetByIdAsync(invoice.Id);
            Assert.NotNull(retrieved);
            Assert.Single(retrieved!.Items);
        }
    }
}