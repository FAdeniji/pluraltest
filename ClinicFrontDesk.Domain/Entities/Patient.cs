namespace ClinicFrontDesk.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Clinic { get; set; } = string.Empty;
        public decimal WalletBalance { get; set; }
        public string Currency { get; set; } = "USD";
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}