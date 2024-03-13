namespace HealthcarePlatform.Models
{
    public class Patient : User
    {
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
    }
}
