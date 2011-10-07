using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web.Areas.Crud
{
    public class CrudAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Crud";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Crud_default",
                "Crud/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
