using HealthcarePlatform.Models;

namespace HealthcarePlatform.DTO
{
    public class PatientDTO
    {
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        UserType UserType { get; set; }
        Gender Gender { get; set; }
    }
}
