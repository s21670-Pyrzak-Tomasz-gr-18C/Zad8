using System.Numerics;
using System.Reflection.Emit;

using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
	{
		public void Configure(EntityTypeBuilder<Doctor> builder)
		{
			builder
				.HasKey(doctor => doctor.IdDoctor);
			builder
				.Property(doctor => doctor.FirstName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(doctor => doctor.LastName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(doctor => doctor.Email)
				.IsRequired()
				.HasMaxLength(100);

			builder.HasData(
				new Doctor { IdDoctor = 1, FirstName = "Stephen", LastName = "Strange", Email = "doctor@strange.com" },
				new Doctor { IdDoctor = 2, FirstName = "Curtis", LastName = "Connors", Email = "lizard@doc.com" },
				new Doctor { IdDoctor = 3, FirstName = "Otto", LastName = "Octavius", Email = "doc@ock.com" },
				new Doctor { IdDoctor = 4, FirstName = "Bruce", LastName = "Banner", Email = "hulk@smash.com" },
				new Doctor { IdDoctor = 5, FirstName = "Victor", LastName = "von Doom", Email = "doctor@doom.com" }
			);
		}
	}
}
