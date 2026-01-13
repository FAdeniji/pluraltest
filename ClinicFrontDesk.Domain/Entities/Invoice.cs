using System;
using System.Collections.Generic;

namespace ClinicFrontDesk.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public string Status { get; set; } = string.Empty;
        public ICollection<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();
        public Patient? Patient { get; set; }
    }

    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public Invoice? Invoice { get; set; }
    }
}