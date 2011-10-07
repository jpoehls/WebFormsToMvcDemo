using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTFWebFormsToMvc.Web
{
    public static class HttpContextHelpers
    {
        /// <summary>
        /// Returns a <see cref="HttpRequestBase"/> for the given <see cref="HttpRequest"/>
        /// by wrapping it in a new <see cref="HttpRequestWrapper"/>.
        /// </summary>
        /// <param name="request">the <see cref="HttpRequest"/> to wrap</param>
        /// <returns>the <see cref="HttpRequestBase"/></returns>
        public static HttpRequestBase Wrap(this HttpRequest request)
        {
            return new HttpRequestWrapper(request);
        }

        /// <summary>
        /// Returns a <see cref="HttpContextBase"/> for the given <see cref="HttpContext"/>
        /// by wrapping it in a new <see cref="HttpContextWrapper"/>.
        /// </summary>
        /// <param name="context">the <see cref="HttpContext"/> to wrap</param>
        /// <returns>the <see cref="HttpContextBase"/></returns>
        public static HttpContextBase Wrap(this HttpContext context)
        {
            return new HttpContextWrapper(context);
        }
    }
}
