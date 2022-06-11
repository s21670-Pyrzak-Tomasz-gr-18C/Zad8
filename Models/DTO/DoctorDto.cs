using System.ComponentModel.DataAnnotations;

namespace doctors.Models.DTO
{
	public class DoctorDto : Person
	{
		[Required]
		[MaxLength(100)]
		[EmailAddress]
		public string Email { get; set; }
	}
}
