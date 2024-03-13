using HealthcarePlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcarePlatform.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext context;

        public DoctorRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            return await context.Doctors.FindAsync(id);
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsBySpecializationAsync(string specialization)
        {
            return await context.Doctors.Where(d => d.Specialization.Name == specialization).ToListAsync();
        }

        public async Task<Doctor> CreateDoctorAsync(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor)
        {
            context.Entry(doctor).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var doctor = await context.Doctors.FindAsync(id);
            if (doctor != null)
            {
                context.Doctors.Remove(doctor);
                await context.SaveChangesAsync();
            }
        }
    }
}
