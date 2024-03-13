using HealthcarePlatform.Models;

namespace HealthcarePlatform.Repositories
{
    public interface IPatientRepository
    {
        Task<Patient> CreatePatientAsync(Patient patient);
        Task DeletePatientAsync(int id);
        Task<List<Patient>> GetAllPatientsAsync();
        Task<Patient> GetPatientByIdAsync(int id);
        Task<Patient> UpdatePatientAsync(int id, Patient patient);
    }
}