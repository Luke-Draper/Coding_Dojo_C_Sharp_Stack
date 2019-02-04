using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostInTheWoods.Models;

namespace LostInTheWoods.Controllers
{
	public class HomeController : Controller
	{
		TrailFactory tr = null;

		[Route("")]
		[HttpGet]
		public IActionResult Index()
		{
			if (tr == null)
			{
				tr = new TrailFactory();
			}
			IEnumerable<Trail> found = tr.FindAll();
			ViewBag.TrailList = found;
			return View();
		}

		[Route("new_trail")]
		[HttpGet]
		public IActionResult NewTrail()
		{
			return View();
		}

		[Route("create_trail")]
		[HttpPost]
		public IActionResult CreateTrail(Trail form)
		{
			if (tr == null)
			{
				tr = new TrailFactory();
			}
			tr.Add(form);
			return RedirectToAction("Index");
		}

		[Route("trail/{id}")]
		[HttpGet]
		public IActionResult Trail(int id)
		{
			if (tr == null)
			{
				tr = new TrailFactory();
			}
			Trail found = tr.FindByID(id);
			ViewBag.Trail = found;
			return View();
		}

	}
}
