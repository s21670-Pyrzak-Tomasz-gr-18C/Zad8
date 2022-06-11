using System;

using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class PatientConfiguration : IEntityTypeConfiguration<Patient>
	{
		public void Configure(EntityTypeBuilder<Patient> builder)
		{
			builder
				.HasKey(patient => patient.IdPatient);
			builder
				.Property(patient => patient.FirstName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(patient => patient.LastName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(patient => patient.Birthdate)
				.IsRequired();

			builder.HasData(
				new Patient { IdPatient = 1, FirstName = "Alan", LastName = "Turing", Birthdate = Convert.ToDateTime("191-06-23") },
				new Patient { IdPatient = 2, FirstName = "Bjarne", LastName = "Stroustrup", Birthdate = Convert.ToDateTime("1950-12-30") },
				new Patient { IdPatient = 3, FirstName = "Ada", LastName = "Lovelace", Birthdate = Convert.ToDateTime("1815-12-10") },
				new Patient { IdPatient = 4, FirstName = "Dennis", LastName = "Ritchie", Birthdate = Convert.ToDateTime("1914-09-09") },
				new Patient { IdPatient = 5, FirstName = "Ken", LastName = "Thompson", Birthdate = Convert.ToDateTime("1943-02-04") }
			);
		}
	}
}
