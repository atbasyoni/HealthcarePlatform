using HealthcarePlatform.Models;

namespace HealthcarePlatform.Repositories
{
    public interface IPatientRepository
    {
        Task<User> CreatePatientAsync(User patient);
        Task DeletePatientAsync(int id);
        Task<IEnumerable<User>> GetAllPatientsAsync();
        Task<User> GetPatientByIdAsync(int id);
        Task<User> UpdatePatientAsync(int id, User patient);
    }
}