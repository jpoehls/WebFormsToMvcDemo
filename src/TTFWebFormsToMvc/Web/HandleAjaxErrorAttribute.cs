using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web
{
    /// <summary>
    /// Handles errors by sending an error status code
    /// and a JSON object with the exception details
    /// to the client.
    /// </summary>
    public class HandleAjaxErrorAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                string friendlyCaption = "An error has occured.";
                string friendlyMessage = filterContext.Exception.Message;
                string technicalDetails = filterContext.Exception.ToString();

                filterContext.Result = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new
                    {
                        caption = friendlyCaption,
                        message = friendlyMessage,
                        details = technicalDetails
                    }
                };

                filterContext.ExceptionHandled = true;
                filterContext.HttpContext.Response.Clear();
                filterContext.HttpContext.Response.StatusCode = 500;

                // Certain versions of IIS will sometimes use their own error page when
                // they detect a server error. Setting this property indicates that we
                // want it to try to render ASP.NET MVC's error page instead.
                filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            }
        }
    }
}
