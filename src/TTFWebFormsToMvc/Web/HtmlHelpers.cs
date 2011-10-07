using System;

namespace TTFWebFormsToMvc.Web
{
    public static class HtmlHelpers
    {
        public static MvcScriptManager ScriptManager(this System.Web.Mvc.HtmlHelper helper)
        {
            var context = helper.ViewContext.HttpContext;
            return MvcScriptManager.Get(context);
        }
    }
}