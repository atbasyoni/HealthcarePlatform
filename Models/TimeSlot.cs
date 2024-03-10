namespace HealthcarePlatform.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public TimeSpan Time { get; set; }
        public int AppointmentId { get; set; }

        //Navigation Properties
        public Appointment Appointment { get; set; }
    }
}
