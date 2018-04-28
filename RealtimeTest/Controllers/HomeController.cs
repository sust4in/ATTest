using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace RealtimeTest.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(string m)
		{
			Response.Redirect(m);
			return View();
		}

		public ActionResult About()
		{
			
			try
			{
				MD5 md5;
			}
			catch (Exception)
			{
				throw;
			}
			
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
