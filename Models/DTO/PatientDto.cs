using System;

namespace doctors.Models.DTO
{
	public class PatientDto : Person
	{
		public DateTime Birthdate { get; set; }
	}
}
