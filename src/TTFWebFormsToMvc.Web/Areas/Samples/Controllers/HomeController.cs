using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web.Areas.Samples.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Samples/Home/index

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /samples/home/skip-validation

        [HttpPost]
        //[ValidateInput(false)]
        [ActionName("skip-validation")]
        public ActionResult SkipValidation(string input)
        {
            return new EmptyResult();
        }

    }
}
