using HealthcarePlatform.DTO;
using HealthcarePlatform.Models;
using HealthcarePlatform.Repositories;

namespace HealthcarePlatform.Services
{
    public class PatientService
    {
        private readonly IPatientRepository patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public void AddPatient(Patient patient)
        {
            /*
            Patient p = new Patient() 
            {
                UserName = patient.UserName,
                Firstname = patient.Firstname,
                Lastname = patient.Lastname,
                Email = patient.Email,
                Birthdate = patient.Birthdate,
                Image = patient.Image,
                PhoneNumber = patient.PhoneNumber,
                //PasswordHash 
            };
            */

            patientRepository.CreatePatientAsync(patient);
        }

        public async Task<Patient> GetPatientById(int patientId)
        {
            return await patientRepository.GetPatientByIdAsync(patientId);
        }

        public async Task<Patient> UpdatePatient(int id, Patient updatedPatient)
        {
            return await patientRepository.UpdatePatientAsync(id, updatedPatient);
        }

        public async Task RemovePatient(int patientId)
        {
            await patientRepository.DeletePatientAsync(patientId);
        }

        public async Task<List<Patient>> GetAllPatients()
        {
            return await patientRepository.GetAllPatientsAsync();
        }
        /*
        public List<Patient> SearchPatients(string searchTerm)
        {
            // Implement search logic based on patient properties such as name, address, etc.
            // For simplicity, this example searches for patients whose name contains the search term.
            //return patientRepository.GetAllPatientsAsync().FindAll(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }
        */
    }
}
