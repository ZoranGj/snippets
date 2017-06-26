using System.Web.Mvc;

using CodeProcessor.Files;
using CodeProcessor.Logic;

namespace CodeSnippets.Controllers
{
	public class HomeController : Controller
    {
        private readonly IFileReader fileReader;
        private readonly IValidator validator;

        public HomeController(IFileReader _fileReader, IValidator _validator)
        {
            fileReader = _fileReader;
            validator = _validator;
        }

        public ActionResult Index()
        {
			return View();
		}

		public ActionResult Insert()
        {
			return View(); 
		}

		public ActionResult Snippets()
        {
			return View();
		}

		public ActionResult About()
        {
			return View(); 
		}
	}
}