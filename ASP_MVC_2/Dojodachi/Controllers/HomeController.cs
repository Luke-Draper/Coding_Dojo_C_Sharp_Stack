using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Newtonsoft.Json;

namespace Dojodachi.Controllers
{
	public class HomeController : Controller
	{

		private Dachi GetDachi()
		{
			Dachi dachi;
			if (HttpContext.Session.GetString("dachi") == null)
			{
				dachi = new Dachi();
				SetDachi(dachi);
			}
			else
			{
				dachi = JsonConvert.DeserializeObject<Dachi>(HttpContext.Session.GetString("dachi"));
			}
			return dachi;
		}
		private void SetDachi(Dachi dachi)
		{
			HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dachi));
		}

		[Route("")]
		[HttpGet]
		public IActionResult Index()
		{
			Dachi dachi = GetDachi();

			ViewBag.Dachi = dachi;
			List<string> messages = new List<string>();

			if(TempData["original_fullness"] != null)
			{
				int temp = dachi.Fullness - (int)TempData["original_fullness"];
				if (temp > 0)
				{
					messages.Add("Your Dojodachi gained " + temp + " fullness!");
				}
				else
				{
					messages.Add("Your Dojodachi lost " + (-1*temp) + " fullness!");
				}
			}
			if(TempData["original_happiness"] != null)
			{
				int temp = dachi.Happiness - (int)TempData["original_happiness"];
				if (temp > 0)
				{
					messages.Add("Your Dojodachi gained " + temp + " happiness!");
				}
				else
				{
					messages.Add("Your Dojodachi lost " + (-1*temp) + " happiness!");
				}
			}
			if(TempData["original_meals"] != null)
			{
				int temp = dachi.Meals - (int)TempData["original_meals"];
				if (temp > 0)
				{
					messages.Add("Your Dojodachi gained " + temp + " meals!");
				}
				else
				{
					messages.Add("Your Dojodachi lost " + (-1*temp) + " meals!");
				}
			}
			if(TempData["original_energy"] != null)
			{
				int temp = dachi.Energy - (int)TempData["original_energy"];
				if (temp > 0)
				{
					messages.Add("Your Dojodachi gained " + temp + " energy!");
				}
				else
				{
					messages.Add("Your Dojodachi lost " + (-1*temp) + " energy!");
				}
			}

			ViewBag.Reset = false;

			if (dachi.HasWon())
			{
				messages.Add("Your Dojodachi has Won!");
				ViewBag.Reset = true;
			}
			else if (!dachi.Alive)
			{
				messages.Add("Your Dojodachi has Lost!");
				ViewBag.Reset = true;
			}

			ViewBag.Messages = messages;

			return View();
		}


		[Route("feed")]
		[HttpPost]
		public IActionResult Feed()
		{
			Dachi dachi = GetDachi();
			TempData["original_fullness"] = dachi.Fullness;
			TempData["original_meals"] = dachi.Meals;
			dachi.Feed();
			SetDachi(dachi);
			return RedirectToAction("Index");
		}

		[Route("play")]
		[HttpPost]
		public IActionResult Play()
		{
			Dachi dachi = GetDachi();
			TempData["original_happiness"] = dachi.Happiness;
			TempData["original_energy"] = dachi.Energy;
			dachi.Play();
			SetDachi(dachi);
			return RedirectToAction("Index");
		}
		
		[Route("work")]
		[HttpPost]
		public IActionResult Work()
		{
			Dachi dachi = GetDachi();
			TempData["original_energy"] = dachi.Energy;
			TempData["original_meals"] = dachi.Meals;
			dachi.Work();
			SetDachi(dachi);
			return RedirectToAction("Index");
		}
		
		[Route("sleep")]
		[HttpPost]
		public IActionResult Sleep()
		{
			Dachi dachi = GetDachi();
			TempData["original_fullness"] = dachi.Fullness;
			TempData["original_happiness"] = dachi.Happiness;
			TempData["original_energy"] = dachi.Energy;
			dachi.Sleep();
			SetDachi(dachi);
			return RedirectToAction("Index");
		}

		[Route("reset")]
		[HttpPost]
		public IActionResult Reset()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Index");
		}
	}
}
