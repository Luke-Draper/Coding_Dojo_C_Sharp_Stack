using Microsoft.AspNetCore.Mvc;
namespace Dojo_Survey.Controllers
{
	public class DojoSurveyController : Controller
	{
		[HttpGet]
		[Route("")]
		public ViewResult Index()
		{
			return View();
		}

		[HttpPost]
		[Route("result")]
		public ViewResult Result(string name, string location, string favorite_language, string comment)
		{
			ViewBag.Name = name;
			ViewBag.Location = location;
			ViewBag.FavoriteLanguage = favorite_language;
			ViewBag.Comment = comment;
			return View();
		}
	}
}
