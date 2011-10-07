using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace TTFWebFormsToMvc.Web
{
    public static class SessionDataHelpers
    {
        public static bool ShowWelcomeMessage(this HttpSessionState session, bool? value = null)
        {
            return ShowWelcomeMessage(new HttpSessionStateWrapper(session), value);
        }

        public static bool ShowWelcomeMessage(this HttpSessionStateBase session, bool? value = null)
        {
            const string key = "ShowWelcomeMessage";

            if (value.HasValue)
            {
                // Add to session.
                session[key] = value.Value;
                return value.Value;
            }
            else
            {
                // Get from session.
                if (session[key] is bool)
                    return (bool)session[key];
            }

            // Default.
            return false;
        }
    }
}
