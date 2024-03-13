using HealthcarePlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcarePlatform.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext context;

        public PatientRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetAllPatientsAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetPatientByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<User> CreatePatientAsync(User patient)
        {
            context.Users.Add(patient);
            await context.SaveChangesAsync();
            return patient;
        }

        public async Task<User> UpdatePatientAsync(int id, User patient)
        {
            context.Entry(patient).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return patient;
        }

        public async Task DeletePatientAsync(int id)
        {
            var patient = await context.Users.FindAsync(id);
            if (patient != null)
            {
                context.Users.Remove(patient);
                await context.SaveChangesAsync();
            }
        }
    }
}
