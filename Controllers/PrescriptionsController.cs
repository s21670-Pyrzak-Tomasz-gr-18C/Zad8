using System.Threading.Tasks;
using System;

using doctors.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using doctors.Models;

namespace doctors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PrescriptionsController : ControllerBase
	{
		private readonly IPrescriptionsDatabaseService _databaseService;

		public PrescriptionsController(IPrescriptionsDatabaseService databaseService)
		{
			_databaseService = databaseService;
		}

		[HttpGet]
		public async Task<IActionResult> GetPrescriptionAsync([FromQuery] string idPrescription)
		{
			if (idPrescription == null)
				return Ok(await _databaseService.GetPrescriptionsAsync());

			var prescription = await _databaseService.GetPrescriptionAsync(Convert.ToInt32(idPrescription));

			return prescription == null
				? NotFound($"Couldn't find prescription with ID {idPrescription}")
				: Ok(prescription);
		}
	}
}
