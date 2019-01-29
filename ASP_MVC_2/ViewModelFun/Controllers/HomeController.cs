using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
	public class HomeController : Controller
	{
		[Route("")]
		[HttpGet]
		public IActionResult Index()
		{
			string message = "Heyo! This is my message!";
			return View("Index",message);
		}
		[Route("numbers")]
		[HttpGet]
		public IActionResult Numbers()
		{
			int[] nums = {1,2,3,4,5,6,7,8,9,10};
			return View(nums);
		}
		[Route("user")]
		[HttpGet]
		public IActionResult User()
		{
			User us = new User(){FirstName="Jimmy",LastName="John"};
			return View(us);
		}
		[Route("users")]
		[HttpGet]
		public IActionResult Users()
		{
			List<User> us = new List<User>()
			{
				new User(){FirstName="Jimmy",LastName="John"},
				new User(){FirstName="Jeremiah",LastName="Jimvall"},
				new User(){FirstName="Jenny",LastName="Johanna"},
				new User(){FirstName="Jechos",LastName="Joey"},
			};
			return View(us);
		}

	}
}
