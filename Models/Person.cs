using System.ComponentModel.DataAnnotations;

namespace doctors.Models
{
	public class Person
	{
		[Required]
		[MaxLength(100)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(100)]
		public string LastName { get; set; }
	}
}
