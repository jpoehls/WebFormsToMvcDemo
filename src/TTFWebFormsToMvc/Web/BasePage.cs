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
        protected override void OnLoad(EventArgs e)
        {
            if (Session.ShowWelcomeMessage())
            {
                string message = string.Format("Hello {0}!", User.Identity.Name);
                ShowMessage(message);
                Session.ShowWelcomeMessage(false);
            }

            base.OnLoad(e);
        }

        protected void ShowError(string message)
        {
            const string messageTemplate = "<p class='error'>{0}</p>";

            message = string.Format(messageTemplate,
                                    WebUtility.HtmlEncode(message));

            ShowMessage(message, safeHtml: true);
        }

        protected void ShowMessage(string message, bool safeHtml = false)
        {
            const string scriptTemplate = "humane({0});";

            if (!safeHtml)
            {
                message = WebUtility.HtmlEncode(message);
            }

            string script = string.Format(scriptTemplate,
                                          message.ToJsonString());

            ClientScript.RegisterStartupScript(this.GetType(),
                                               key: message,
                                               script: script,
                                               addScriptTags: true);
        }
    }
}
