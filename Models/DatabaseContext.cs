using System.Numerics;

using doctors.Configurations;

using Microsoft.EntityFrameworkCore;

namespace doctors.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext()
		{
		}

		public DatabaseContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Medicament> Medicaments { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Prescription> Prescriptions { get; set; }
		public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new DoctorConfiguration());
			modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
			modelBuilder.ApplyConfiguration(new PatientConfiguration());
			modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
			modelBuilder.ApplyConfiguration(new PrescriptionMedicamentConfiguration());
		}
	}
}
