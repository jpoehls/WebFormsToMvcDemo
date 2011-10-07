using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTFWebFormsToMvc.WebMvcTemplate.Models;

namespace TTFWebFormsToMvc.WebMvcTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FirstName = "Joshua";
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            
            return View(new StrongViewModel
            {
                FirstName = "Joshua"
            });
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
