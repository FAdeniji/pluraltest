using System;
using System.Collections.Generic;

namespace ClinicFrontDesk.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Clinic { get; set; } = string.Empty;
        public string AppointmentType { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public string Status { get; set; } = string.Empty;
        public Patient? Patient { get; set; }
    }
}