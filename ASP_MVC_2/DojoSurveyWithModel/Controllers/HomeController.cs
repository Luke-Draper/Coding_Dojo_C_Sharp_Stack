using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
{
	public class HomeController : Controller
	{
		[Route("")]
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[Route("result")]
		public ViewResult Result(Survey input)
		{
			ViewBag.Survey = input;
			return View();
		}

	}
}
