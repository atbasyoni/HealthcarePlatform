namespace HealthcarePlatform.Models
{
    public class Doctor : User
    {
        Specialization Specialization { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
