using HealthcarePlatform.Models;
using HealthcarePlatform.Repositories;

namespace HealthcarePlatform.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository) 
        {
            this.doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {
            return await doctorRepository.GetDoctorsAsync();
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            return await doctorRepository.GetDoctorByIdAsync(id);
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsBySpecializationAsync(string specialization)
        {
            return await doctorRepository.GetDoctorsBySpecializationAsync(specialization);
        }

        public async Task<Doctor> CreateDoctorAsync(Doctor doctor)
        {
            // Add business logic for doctor creation if needed
            return await doctorRepository.CreateDoctorAsync(doctor);
        }

        public async Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor)
        {
            // Add business logic for doctor update if needed
            return await doctorRepository.UpdateDoctorAsync(id, doctor);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            // Add business logic for doctor deletion if needed
            await doctorRepository.DeleteDoctorAsync(id);
        }
    }
}
