using System;
using System.Linq;
using System.Web;

namespace TTFWebFormsToMvc.Web
{
    public class ClientScriptDebugModeHelper
    {
        private readonly HttpContextBase _context;
        private const string CookieName = "DEBUG-MODE";

        private ClientScriptDebugModeHelper(HttpContextBase context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns true/false whether the debug version of client scripts
        /// should be used.
        /// </summary>
        public bool InDebugMode()
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }

        public static ClientScriptDebugModeHelper Current()
        {
            var context = HttpContext.Current.Wrap();
            return For(context);
        }

        public static ClientScriptDebugModeHelper For(HttpContextBase context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            const string key = "ClientScriptDebugModeHelper";
            if (context.Items[key] == null)
                context.Items[key] = new ClientScriptDebugModeHelper(context);

            return (ClientScriptDebugModeHelper)context.Items[key];
        }
    }
}
