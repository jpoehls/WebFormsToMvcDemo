using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TTFWebFormsToMvc.Web
{
    public class MvcScriptManager
    {
        private const string SCRIPT_MANAGER_KEY = "MvcScriptManager";

        private readonly HttpContextBase _context;
        private readonly List<string> _scriptIncludes;
        private readonly List<string> _scriptTexts;
        private readonly ClientScriptDebugModeHelper _debugModeHelper;

        private bool DebugMode { get { return _debugModeHelper.InDebugMode(); } }

        public MvcScriptManager(HttpContextBase context)
        {
            _context = context;
            _debugModeHelper = ClientScriptDebugModeHelper.For(context);
            _scriptIncludes = new List<string>();
            _scriptTexts = new List<string>();
        }

        public MvcHtmlString AddScript(string script, bool addScriptTags)
        {
            if (addScriptTags)
            {
                script = "<script type='text/javascript'>" + script + "</script>";
            }

            if (!_scriptTexts.Contains(script))
            {
                _scriptTexts.Add(script);
            }

            return MvcHtmlString.Empty;
        }

        /// <summary>
        /// Adds a script to the list of includes to reference
        /// when the <see cref="Render"/> method is called.
        /// Include will only be rendered when <see cref="DebugMode"/> is enabled.
        /// </summary>
        public MvcHtmlString AddScript(string scriptPath)
        {
            if (DebugMode)
            {
                var scriptUrl = UrlHelper.GenerateContentUrl(scriptPath, _context);
                if (!_scriptIncludes.Contains(scriptUrl, StringComparer.OrdinalIgnoreCase))
                {
                    _scriptIncludes.Add(scriptUrl);
                }
            }

            return MvcHtmlString.Empty;
        }

        /// <summary>
        /// Renders a reference to the given script file.
        /// </summary>
        public MvcHtmlString AddScriptHere(string scriptPath)
        {
            var scriptUrl = UrlHelper.GenerateContentUrl(scriptPath, _context);

            return MvcHtmlString.Create(String.Format("<script type='text/javascript' src='{0}'></script>", scriptUrl));
        }

        /// <summary>
        /// Renders a reference to the given script file based on
        /// whether <see cref="DebugMode"/> is enabled or not.
        /// </summary>
        /// <param name="debug">the script path to include if <see cref="DebugMode"/> is enabled</param>
        /// <param name="release">the script path to inclue if <see cref="DebugMode"/> is disabled</param>
        public MvcHtmlString AddScriptHere(string debug, string release)
        {
            if (DebugMode && !string.IsNullOrEmpty(debug))
            {
                return AddScriptHere(debug);
            }

            if (!DebugMode && !string.IsNullOrEmpty(release))
            {
                return AddScriptHere(release);
            }

            return MvcHtmlString.Empty;
        }

        /// <summary>
        /// Renders the references to all of the includes.
        /// </summary>
        public MvcHtmlString RenderScripts()
        {
            if (_scriptIncludes.Count > 0)
            {
                var sb = new StringBuilder();
                foreach (var scriptUrl in _scriptIncludes)
                {
                    sb.AppendLine(String.Format("<script type='text/javascript' src='{0}'></script>",
                                                scriptUrl));
                }

                foreach (var script in _scriptTexts)
                {
                    sb.AppendLine(script);
                }

                return MvcHtmlString.Create(sb.ToString());
            }

            return MvcHtmlString.Empty;
        }

        /// <summary>
        /// Gets an instance of the <see cref="MvcScriptManager"/> for
        /// the given <see cref="HttpContextBase"/>.
        /// </summary>
        public static MvcScriptManager Get(HttpContextBase context)
        {
            var scriptManager = context.Items[SCRIPT_MANAGER_KEY] as MvcScriptManager;
            if (scriptManager == null)
            {
                scriptManager = new MvcScriptManager(context);
                context.Items[SCRIPT_MANAGER_KEY] = scriptManager;
            }

            return scriptManager;
        }
    }
}
