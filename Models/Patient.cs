using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace doctors.Models
{
	public class Patient : Person
	{
		public int IdPatient { get; set; }
		public DateTime Birthdate { get; set; }

		public virtual ICollection<Prescription> Prescriptions { get; set; }
	}
}
