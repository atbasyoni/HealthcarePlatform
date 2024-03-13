using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthcarePlatform.Models
{
    public enum Status { pending, completed, canceled }

    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Price { get; set; }

        public Status TicketStatus { get; set; }

        // Foreign Keys
        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        public int TimeSlotId { get; set; }

        //Navigation properties
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        [ForeignKey("PatientId")]
        public User Patient { get; set; }

        [ForeignKey("TimeSlotId")]
        public TimeSlot TimeSlot { get; set; }
    }
}
