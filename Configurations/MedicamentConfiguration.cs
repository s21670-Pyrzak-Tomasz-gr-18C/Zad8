using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
	{
		public void Configure(EntityTypeBuilder<Medicament> builder)
		{
			builder
				.HasKey(medicament => medicament.IdMedicament);
			builder
				.Property(medicament => medicament.Name)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(medicament => medicament.Description)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(medicament => medicament.Type)
				.IsRequired()
				.HasMaxLength(100);

			builder.HasData(
				new Medicament { IdMedicament = 1, Name = "Hydroxyzine", Description = "Sleep deprivation", Type = "Antihistamine" },
				new Medicament { IdMedicament = 2, Name = "Mephedrone", Description = "Multi-purpose", Type = "Stimulant" },
				new Medicament { IdMedicament = 3, Name = "Prozac", Description = "Depression", Type = "Antidepressant" },
				new Medicament { IdMedicament = 4, Name = "Vyvanse", Description = "ADHD", Type = "Stimulant" },
				new Medicament { IdMedicament = 5, Name = "Xanax", Description = "Depression", Type = "Antidepressant" }
			);
		}
	}
}
