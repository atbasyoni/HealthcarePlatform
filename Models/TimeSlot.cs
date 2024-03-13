using System.ComponentModel.DataAnnotations.Schema;

namespace HealthcarePlatform.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public TimeSpan Time { get; set; }

        // Foreign Key
        public int AppointmentId { get; set; }

        //Navigation Properties
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }
    }
}
