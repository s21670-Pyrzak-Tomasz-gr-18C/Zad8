using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace doctors.Models
{
	public class Doctor : Person
	{
		public int IdDoctor { get; set; }
		public string Email { get; set; }

		public virtual ICollection<Prescription> Prescriptions { get; set; }
	}
}
