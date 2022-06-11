using System.Collections.Generic;
using System.Threading.Tasks;

using doctors.Models;
using doctors.Models.DTO;

namespace doctors.Services
{
	public interface IPrescriptionsDatabaseService
	{
		Task<IEnumerable<PrescriptionDto>> GetPrescriptionsAsync();
		Task<PrescriptionDto> GetPrescriptionAsync(int idPrescription);
	}
}
