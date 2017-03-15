using System;
using System.Linq;
using System.Web.Mvc;

namespace CodeSnippets.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult Insert() {
			return View(); 
		}

		public ActionResult Snippets() {
			return View();
		}

		public ActionResult About() {
			return View(); 
		}
	}
}