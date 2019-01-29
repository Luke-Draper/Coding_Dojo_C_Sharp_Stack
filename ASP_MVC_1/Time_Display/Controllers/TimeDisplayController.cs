using Microsoft.AspNetCore.Mvc;
namespace Time_Display.Controllers
{
	public class TimeDisplayController : Controller
	{
		[HttpGet]
		[Route("")]
		public ViewResult Index()
		{
			return View();
		}
	}
}
