using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace TTFWebFormsToMvc.Web
{
    public class BasePage : System.Web.UI.Page
    {
        protected void ShowError(string message)
        {
            const string messageTemplate = "<p class='error'>{0}</p>";
            const string scriptTemplate = "humane({0});";

            message = string.Format(messageTemplate,
                                    WebUtility.HtmlEncode(message));

            string script = string.Format(scriptTemplate,
                                          message.ToJsonString());

            ClientScript.RegisterStartupScript(this.GetType(),
                                               key: message,
                                               script: script,
                                               addScriptTags: true);
        }
    }
}
