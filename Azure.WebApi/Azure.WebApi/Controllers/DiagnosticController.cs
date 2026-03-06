using Microsoft.AspNetCore.Mvc;

namespace Azure.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DiagnosticController : ControllerBase
	{
		[HttpGet]
		public ActionResult<string> Get()
		{
			return Ok(new
			{
				message = "Diagnostic controller works fine",
				datetime = DateTime.UtcNow
			});
		}
	}
}
