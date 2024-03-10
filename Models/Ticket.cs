namespace HealthcarePlatform.Models
{
    enum Status { pending, completed, canceled }

    public class Ticket
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public Status TicketStatus { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int TimeSlotId { get; set; }

        //Navigation properties
        public Doctor Doctor { get; set; }
        public User Patient { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}
