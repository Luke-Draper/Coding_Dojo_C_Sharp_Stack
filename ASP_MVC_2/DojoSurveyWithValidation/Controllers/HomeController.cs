using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers
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
			if(ModelState.IsValid)
			{
				ViewBag.Survey = input;
				return View("Result");
			}
			else
			{
				return View("Index");
			}
		}

	}
}
