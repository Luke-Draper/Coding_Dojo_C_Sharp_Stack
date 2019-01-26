using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers
{
	public class RazorFunController : Controller
	{
		[HttpGet]
		[Route("")]
		public ViewResult Index()
		{
			return View();
		}
	}
}
