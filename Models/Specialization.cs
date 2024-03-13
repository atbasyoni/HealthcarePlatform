using System.ComponentModel.DataAnnotations;

namespace HealthcarePlatform.Models
{
    public class Specialization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // Navigation Properties
        public virtual List<Doctor> Doctors { get; set; }
    }
}
