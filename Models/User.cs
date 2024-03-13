using Microsoft.AspNetCore.Identity;

namespace HealthcarePlatform.Models
{
    enum Gender { male, female }
    enum UserType { admin, doctor, patient }

    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Image { get; set; }
        UserType UserType { get; set; }
        Gender Gender { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
