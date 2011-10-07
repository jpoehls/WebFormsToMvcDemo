using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTFWebFormsToMvc.Data;

namespace TTFWebFormsToMvc.Web.Areas.Crud.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Crud/Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /crud/home/edit

        [HttpGet]
        public ActionResult Edit()
        {
            ViewBag.Products = Product.GetAll();
            return View();
        }
       
        //
        // POST: /crud/home/edit/{id}

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            Product.Save(product);
            return new RedirectResult("~/crud/home");
        }

    }
}
