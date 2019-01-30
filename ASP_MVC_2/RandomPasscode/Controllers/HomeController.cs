using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using System.Text;

namespace RandomPasscode.Controllers
{
	public class HomeController : Controller
	{
		public string getPass() {
			Random rand = new Random();
			var stringBuilder = new StringBuilder();

			while (stringBuilder.Length - 1 <= 14)
			{
				var character = (char)rand.Next(48, 123);
				if (!char.IsControl(character))
				{
					stringBuilder.Append(character);
				}
			}

			return stringBuilder.ToString();
		}

		[Route("")]
		[HttpGet]
		public IActionResult Index()
		{
			int PasswordCount = 0;
			if(HttpContext.Session.GetInt32("PasswordCount") != null)
			{
				PasswordCount = (int)HttpContext.Session.GetInt32("PasswordCount");
			};
			PasswordCount++;
			HttpContext.Session.SetInt32("PasswordCount",PasswordCount);
			ViewBag.PasswordCount = PasswordCount;
			ViewBag.Password = getPass();
			return View();
		}

	}
}
