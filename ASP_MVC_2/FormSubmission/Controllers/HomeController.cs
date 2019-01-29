using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
	public class HomeController : Controller
	{
		[Route("")]
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[Route("result")]
		[HttpGet]
		public IActionResult Result()
		{
			return View();
		}

		[Route("create")]
		[HttpPost]
		public IActionResult Create(Registration reg)
		{
			if(ModelState.IsValid)
			{
				return RedirectToAction("Result");
			}
			else
			{
				return View("Index");
			}
		}

	}
}
