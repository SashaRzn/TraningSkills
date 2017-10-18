using System.Collections.Generic;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			List<Book> books = new List<Book>();
			using (LibraryContext context = new LibraryContext())
			{				
				foreach (var item in context.Books)
				{
					books.Add(item);
				}
			}
			return View(books);			
		}		
	}
}