using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web.Areas.Samples
{
    public class SamplesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Samples";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Samples_default",
                "Samples/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
