using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
			Random rnd = null;
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

				// remember to use [HttpPost] attributes!
				[HttpPost]
				[Route("quotes")]
				public IActionResult Method(string Name, string Content)
				{
					Quotes new_quote = new Quotes {
						Name = Name,
						Content = Content,
						Created_At = DateTime.Now,
					};
					if (rnd == null)
					{
						rnd = new Random();
					}
					int id = rnd.Next(1);

					string query = $"INSERT INTO quotes (quote_id, name, content, created_at) VALUES ({id}, '{new_quote.Name}', '{new_quote.Content}', '{new_quote.Created_At.ToString("yyyy-MM-dd HH:mm:ss")}')";
					DbConnector.Execute(query);

					return RedirectToAction("Quotes");
				}

				[Route("quotes")]
        [HttpGet]
        public IActionResult Quotes()
        {
					
    	    	List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes");
            ViewBag.Quotes = AllQuotes;
            return View();
        }

    }
}
