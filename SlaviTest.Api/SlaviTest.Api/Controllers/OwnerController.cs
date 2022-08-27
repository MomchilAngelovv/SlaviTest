using Microsoft.AspNetCore.Mvc;
using SlaviTest.Api.Models;

namespace SlaviTest.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OwnerController : ControllerBase
	{
		//https://localhost:7017/owner/name
		[HttpGet("name")]
		public IActionResult GetOwnwerName()
		{
			return this.Ok("Slavi Kadiyski");
		}

		[HttpPost("name")]
		public IActionResult GetOwnwerName(PersonModel person)
		{
			return this.Ok($"Name: {person.Name}, Age: {person.Age + 1}");
		}
	}
}
