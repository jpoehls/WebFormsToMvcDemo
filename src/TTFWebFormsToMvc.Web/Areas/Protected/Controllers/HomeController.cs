using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web.Areas.Protected.Controllers
{
    public class HomeController : SecureController
    {
        //
        // GET: /protected/default.aspx

        public ActionResult Default()
        {
            if (Session.ShowWelcomeMessage())
            {
                ViewBag.ShowWelcomeMessage = true;
                Session.ShowWelcomeMessage(false);
            }
            else
            {
                ViewBag.ShowWelcomeMessage = false;
            }

            return View();
        }

    }
}
