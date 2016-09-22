using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BridgeWebApi.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		[HttpPost]
		public ActionResult Save(UserData user)
		{
			Console.WriteLine( "Name:{0}, Age: {1}",
								user.name, user.age );
			// save data
			user.id = 1;
			return RedirectToAction( "list", new RouteValueDictionary( user ) );
		}

		public ActionResult List(UserData user)
		{
			return View(user);
		}

		public ActionResult Duda()
		{
			return View("Error");
		}
	}
}
