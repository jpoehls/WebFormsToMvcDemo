using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web.Areas.Protected
{
    public class ProtectedAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Protected";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //context.MapRoute(
            //    "Protected_default",
            //    "Protected/{action}.aspx",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Default",
            //        id = UrlParameter.Optional
            //    }
            //);

            context.MapRoute(
                "Protected_default",
                "Protected/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
