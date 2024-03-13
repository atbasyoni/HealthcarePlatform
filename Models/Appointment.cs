using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthcarePlatform.Models
{
    public enum WorkingDay { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public WorkingDay WorkingDays { get; set; }

        // Foreign Keys
        public int DoctorId { get; set; }

        //Navigation properties
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }

        public virtual List<TimeSlot> TimeSlots { get; set; }
    }
}
