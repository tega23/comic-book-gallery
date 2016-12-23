using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Details()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                Redirect("/");
            }
            return Content("Welcome to the comic book controller");
        }
    }
}