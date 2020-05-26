using Microsoft.EntityFrameworkCore;
using Task11.Configurations;

namespace Task11.Models
{
    public class DatabaseDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        public DatabaseDbContext(DbContextOptions options)
            :base(options){ 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorEfConfiguration());

            modelBuilder.ApplyConfiguration(new PatientEfConfiguration());

            modelBuilder.ApplyConfiguration(new PrescriptionEfConfiguration());

            modelBuilder.ApplyConfiguration(new MedicamentEfConfiguration());

            modelBuilder.ApplyConfiguration(new Prescription_MedicamentEfConfiguration());
        }
    }
}
