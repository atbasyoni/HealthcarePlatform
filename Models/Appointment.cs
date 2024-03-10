namespace HealthcarePlatform.Models
{
    enum WorkingDay { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public class Appointment
    {
        public int Id { get; set; }
        public WorkingDay WorkingDays { get; set; }
        public int DoctorId { get; set; }
        public List<TimeSlot> TimeSlots { get; set; }

        //Navigation properties
        public Doctor Doctor { get; set; }
    }
}
