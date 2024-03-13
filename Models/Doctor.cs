using System.ComponentModel.DataAnnotations.Schema;

namespace HealthcarePlatform.Models
{
    public class Doctor : User
    {
        // Foreign Keys
        public int SpecializationId { get; set; }

        [ForeignKey("SpecializationId")]
        public virtual Specialization Specialization { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
    }
}
