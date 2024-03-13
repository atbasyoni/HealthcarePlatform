using HealthcarePlatform.Models;

namespace HealthcarePlatform.Repositories
{
    public interface IDoctorRepository
    {
        Task<Doctor> CreateDoctorAsync(Doctor doctor);
        Task DeleteDoctorAsync(int id);
        Task<Doctor> GetDoctorByIdAsync(int id);
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
        Task<IEnumerable<Doctor>> GetDoctorsBySpecializationAsync(string specialization);
        Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor);
    }
}